import time
import winsound

# Речник за конвертиране на букви и цифри в морзов код
MORSE_CODE_DICT = {
    'A': '.-', 'B': '-...', 'C': '-.-.', 'D': '-..', 'E': '.', 'F': '..-.', 'G': '--.', 'H': '....', 'I': '..',
    'J': '.---', 'K': '-.-', 'L': '.-..', 'M': '--', 'N': '-.', 'O': '---', 'P': '.--.', 'Q': '--.-', 'R': '.-.',
    'S': '...', 'T': '-', 'U': '..-', 'V': '...-', 'W': '.--', 'X': '-..-', 'Y': '-.--', 'Z': '--..',
    '1': '.----', '2': '..---', '3': '...--', '4': '....-', '5': '.....', '6': '-....', '7': '--...', '8': '---..',
    '9': '----.', '0': '-----', ',': '--..--', '.': '.-.-.-', '?': '..--..', "'": '.----.', '!': '-.-.--', '/': '-..-.',
    '(': '-.--.', ')': '-.--.-', '&': '.-...', ':': '---...', ';': '-.-.-.', '=': '-...-', '+': '.-.-.', '-': '-....-',
    '_': '..--.-', '"': '.-..-.', '$': '...-..-', '@': '.--.-.', ' ': '|'
}

# Обратен речник за декодиране от морзов код към текст
REVERSE_MORSE_CODE_DICT = {value: key for key, value in MORSE_CODE_DICT.items()}

# Функция за конвертиране на текст в морзов код
def text_to_morse(text):
    text = text.upper()
    morse_code = ' '.join(MORSE_CODE_DICT.get(char, '') for char in text)
    return morse_code

# Функция за конвертиране от морзов код в текст
def morse_to_text(morse_code):
    words = morse_code.split(' | ')
    decoded_text = ''
    for word in words:
        for code in word.split():
            decoded_text += REVERSE_MORSE_CODE_DICT.get(code, '')
        decoded_text += ' '
    return decoded_text.strip()

# Функция за възпроизвеждане на морзовия код със звуков сигнал
def play_morse(morse_code):
    for symbol in morse_code:
        if symbol == '.':
            winsound.Beep(1000, 200)  # Кратък звуков сигнал за точка
        elif symbol == '-':
            winsound.Beep(1000, 600)  # Дълъг звуков сигнал за тире
        elif symbol == ' ':
            time.sleep(0.2)  # Разделение между символите
        elif symbol == '|':
            time.sleep(0.6)  # Разделение между думите

# Пример за използване на програмата
text = input("Въведете текст на латиница за конвертиране в морзов код: ")
morse_code = text_to_morse(text)
print("Морзов код:", morse_code)

# Възпроизвеждане на морзовия код като звук
play_morse(morse_code)

# Конвертиране обратно от морзов код към текст
decoded_text = morse_to_text(morse_code)
print("Декодиран текст:", decoded_text)
