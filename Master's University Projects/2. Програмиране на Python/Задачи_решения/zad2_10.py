import json

class Client:
    def __init__(self, client_number, phone_number, name, zones_minutes):
        self.client_number = client_number
        self.phone_number = phone_number
        self.name = name
        self.zones_minutes = zones_minutes  # Списък от 4 елемента (национални, зона 1, зона 2, зона 3)

    def to_dict(self):
        return {
            'client_number': self.client_number,
            'phone_number': self.phone_number,
            'name': self.name,
            'zones_minutes': self.zones_minutes
        }

    @staticmethod
    def from_dict(data):
        return Client(data['client_number'], data['phone_number'], data['name'], data['zones_minutes'])
    
# Зарежда данни за абонати от JSON файл
def load_clients(file_name):
    try:
        with open(file_name, 'r') as file:
            data = json.load(file)
            return [Client.from_dict(client) for client in data]
    except FileNotFoundError:
        return []
    
# Записва абонати в JSON файл
def save_clients(clients, file_name):
    with open(file_name, 'w') as file:
        json.dump([client.to_dict() for client in clients], file, indent=4)

# Добавя нов абонат в списъка, ако няма дублиращи се данни
def add_client(clients, client, file_name):
    if not any(c.client_number == client.client_number and c.phone_number == client.phone_number for c in clients):
        clients.append(client)
        save_clients(clients, file_name)
        print(f"Абонатът {client.name} е добавен.")
    else:
        print("Абонатът вече съществува.")

# Изтрива абонат по клиентски номер и телефонен номер
def delete_client(clients, client_number, phone_number, file_name):
    client = next((c for c in clients if c.client_number == client_number and c.phone_number == phone_number), None)
    if client:
        clients.remove(client)
        save_clients(clients, file_name)
        print(f"Абонатът с номер {client_number} и телефонен номер {phone_number} е изтрит.")
    else:
        print("Не е намерен абонат с тези данни.")

# Търси абонат по име
def search_client_by_name(clients, name):
    found_clients = [client for client in clients if name.lower() in client.name.lower()]
    return found_clients

# Търси абонат по клиентски номер
def search_client_by_number(clients, client_number):
    return [client for client in clients if client.client_number == client_number]

# Отпечатва информация за всички абонати
def print_client_info(clients):
    print(f"{'Клиентски N':<15}{'Телефонен N':<15}{'национални':<15}{'Зона 1':<15}{'Зона 2':<15}{'Зона 3':<15}")
    for client in clients:
        print(f"{client.client_number:<15}{client.phone_number:<15}{client.zones_minutes[0]:<15}{client.zones_minutes[1]:<15}{client.zones_minutes[2]:<15}{client.zones_minutes[3]:<15}")

# Извежда броя на телефоните, свързани с даден абонатен номер
def count_phone_numbers_for_client(clients, client_number):
    return sum(1 for client in clients if client.client_number == client_number)

def main():
    file_name = 'clients.json'
    clients = load_clients(file_name)

    while True:
        print("\n--- Меню ---")
        print("1. Добавяне на абонат")
        print("2. Изтриване на абонат")
        print("3. Търсене на абонат по име")
        print("4. Търсене на абонат по абонатен номер")
        print("5. Извеждане на информация за абонатите")
        print("6. Извеждане на брой телефонни номера за абонатен номер")
        print("7. Изход")
        
        choice = input("Изберете опция: ")

        if choice == '1':
            client_number = input("Въведете клиентски номер: ")
            phone_number = input("Въведете телефонен номер: ")
            name = input("Въведете име на клиента: ")
            zones_minutes = list(map(int, input("Въведете изговорени минути в 4 зони (напр. 50 10 15 20): ").split()))
            client = Client(client_number, phone_number, name, zones_minutes)
            add_client(clients, client, file_name)

        elif choice == '2':
            client_number = input("Въведете клиентски номер: ")
            phone_number = input("Въведете телефонен номер: ")
            delete_client(clients, client_number, phone_number, file_name)

        elif choice == '3':
            name = input("Въведете име на клиента: ")
            found_clients = search_client_by_name(clients, name)
            for client in found_clients:
                print(f"Намерени абонати: {client.name}, номер: {client.client_number}, телефон: {client.phone_number}")

        elif choice == '4':
            client_number = input("Въведете клиентски номер: ")
            found_clients = search_client_by_number(clients, client_number)
            for client in found_clients:
                print(f"Намерени абонати: {client.name}, номер: {client.client_number}, телефон: {client.phone_number}")

        elif choice == '5':
            print_client_info(clients)

        elif choice == '6':
            client_number = input("Въведете клиентски номер: ")
            count = count_phone_numbers_for_client(clients, client_number)
            print(f"Брой телефонни номера за абонатен номер {client_number}: {count}")

        elif choice == '7':
            save_clients(clients, file_name)
            print("Изход от програмата.")
            break

        else:
            print("Невалиден избор. Моля, изберете отново.")
            
if __name__ == "__main__":
    main()
