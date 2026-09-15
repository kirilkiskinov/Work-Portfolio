#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <cstring>

using namespace std;

enum kategorii { telefoni = 1, komputri, fotoaparati, smartchasovnici, mishki, aksesoari };

struct komponenti
{
    char proizvoditel[80];
    char name[80];
    int cena;
    kategorii kategoriq;
};

void accept(struct komponenti list[], int s);
void displayElement(struct komponenti komponent);
void display(struct komponenti list[], int s);
void bsortDesc(struct komponenti list[], int s);
void bsortIme(struct komponenti list[], int s);
void tursenePoCenaIKategoria(struct komponenti list[], int s);
char printMenu();

int main()
{
    struct komponenti data[20];
    int n;
    char ch;

    do {
        ch = printMenu();
        switch (ch) {
        case '1':
            int n;
            printf("Vavedete broq elementi za vaveshdane? : ");
            scanf("%d", &n);
            accept(data, n);
            break;
        case '2':
            if (n == -858993460)
            {
                printf("Nqma elementi za pokazvane.");
                system("pause");
            }
            else
            {
                display(data, n);
                system("pause");
            }
            break;
        case '3':
            bsortDesc(data, n);
            display(data, n);
            system("pause");
            break;
        case '4':
            bsortIme(data, n);
            display(data, n);
            system("pause");
            break;
        case '5':
            tursenePoCenaIKategoria(data, n);
            system("pause");
            break;
        }
    } while (ch != '0');

    return 0;
}

char printMenu() {
    char c;
    do {
        system("cls");
        cout << "1. Dobavqne na komponent\n";
        cout << "2. Izvejdane na danni\n";
        cout << "3. Izvejdane na danni v nizhodqsht red\n";
        cout << "4. Izvejdane na danni podredeni po ime\n";
        cout << "5. Tursene po kategoria i cena\n";
        cout << "0. Krai na programata\n\n";
        cout << "Vashiat izbor: ";
        cin >> c;
    } while (c < '0' || c > '5');
    cout << endl;
    return c;
}

void accept(struct komponenti list[80], int s)
{
    int i, j, k;

    for (i = 0; i < s; i++)
    {
        printf("\n\nVavedete danni za komponent #%d", i + 1);

        printf("\nVavedete proizvoditel : ");
        scanf("%s", &list[i].proizvoditel);

        printf("Vavedete ime : ");
        scanf("%s", &list[i].name);

        printf("Vavedete cena : ");
        scanf("%d", &list[i].cena);

        cout << "\Vavedete chislo syotwetstvashto na kategoria.\n\n";
        for (j = telefoni; j <= aksesoari; j++) {
            switch (j) {
            case telefoni: cout << "Telefoni";
                break;
            case komputri: cout << "Komputri";
                break;
            case fotoaparati:  cout << "Fotoaparati";
                break;
            case smartchasovnici: cout << "Smartchasovnici";
                break;
            case mishki: cout << "Mishki";
                break;
            case aksesoari: cout << "Aksesoari";
                break;
            }
            cout << "\t    ";
            cout << " - " << j << "\n";
        }
        do {
            printf("Kategoria = ");
            scanf("%d", &k);
        } while (k <= 0 || k > aksesoari);
        list[i].kategoriq = (kategorii)(k);
    }
}

void displayElement(struct komponenti komponent) {
    printf("%s\t\t%s\t\t%d\t", komponent.proizvoditel, komponent.name, komponent.cena);
    switch (komponent.kategoriq) {
    case telefoni: cout << "Telefoni";
        break;
    case komputri: cout << "Komputri";
        break;
    case fotoaparati:  cout << "Fotoaparati";
        break;
    case smartchasovnici: cout << "Smartchasovnici";
        break;
    case mishki: cout << "Mishki";
        break;
    case aksesoari: cout << "Aksesoari";
        break;
    }
    printf("\n");
}

void display(struct komponenti list[80], int s)
{
    int i;

    printf("\n\nProizvoditel\tIme\t\tCena\tKategoria\n");
    for (i = 0; i < s; i++)
    {
        displayElement(list[i]);
    }
}

void bsortDesc(struct komponenti list[80], int s)
{
    int i, j;
    struct komponenti temp;

    for (i = 0; i < s - 1; i++)
    {
        for (j = 0; j < (s - 1 - i); j++)
        {
            if (list[j].cena < list[j + 1].cena)
            {
                temp = list[j];
                list[j] = list[j + 1];
                list[j + 1] = temp;
            }
        }
    }
}

void bsortIme(struct komponenti list[80], int s)
{
    int i, j;
    struct komponenti temp;

    for (i = 0; i < s - 1; i++)
    {
        for (j = 0; j < (s - 1 - i); j++)
        {
            if (strcmp(list[j].name, list[j + 1].name) > 0) //Compares the C string str1 to the C string str2
            {                                  //if Return value > 0 then it indicates str2 is less than str1.
                temp = list[j];
                list[j] = list[j + 1];
                list[j + 1] = temp;
            }
        }
    }
}

void tursenePoCenaIKategoria(struct komponenti list[], int s) {
    int i, j, k, cena, kategoriq;

    printf("Vavedete cena : ");
    scanf("%d", &cena);

    cout << "\Vavedete chislo syotwetstvashto na kategoria.\n\n";
    for (j = telefoni; j <= aksesoari; j++) {
        switch (j) {
        case telefoni: cout << "Telefoni";
            break;
        case komputri: cout << "Komputri";
            break;
        case fotoaparati:  cout << "Fotoaparati";
            break;
        case smartchasovnici: cout << "Smartchasovnici";
            break;
        case mishki: cout << "Mishki";
            break;
        case aksesoari: cout << "Aksesoari";
            break;
        }
        cout << "\t    ";
        cout << " - " << j << "\n";
    }
    do {
        printf("Kategoria = ");
        scanf("%d", &k);
    } while (k <= 0 || k > aksesoari);
    kategoriq = (kategorii)(k);

    printf("\n\nProizvoditel\tIme\t\t\tCena\tKategoria\n");
    for (i = 0; i < s; i++)
    {
        if (cena < list[i].cena && kategoriq == list[i].kategoriq)
        {
            displayElement(list[i]);
        }
    }
}
