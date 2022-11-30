from random import randint
import time

def player1 ():
# Ввод имени игрока1
    igrok1 = input('Введите имя 1-го играющего ')
    return igrok1

def player2 ():
# Ввод имени игрока2
    igrok2 = input('Введите имя 2-го играющего ')
    return igrok2

def wins ():
# Ввод до скольки побед играем
    win = int(input('До скольки побед играем? '))
    return win

def game (igrok1, igrok2, win):
    list1 = []
    list2 = []
    for i in range(1000):
# Моделирование бросания кубика первым играющим
        print('Кубик бросает', igrok1)
        time.sleep(2)
        n1 = randint(1, 6)
        print('Выпало:', n1)

# Моделирование бросания кубика вторым играющим
        print('Кубик бросает', igrok2)
        time.sleep(2)
        n2 = randint(1, 6)
        print('Выпало:', n2)

#Определение результата (3 возможных варианта)  ИГРА до ОПРЕДЕЛЕННОГО КЛИЧЕСТВА ПОБЕД
        if n1 > n2:
          print('ВЫИГРАЛ', igrok1)
          list1.insert(0, 1)
          count1 = list1.count(1)
          print(igrok1, count1)
          if count1 < win:
            print('Следующая игра')
          else:
            print('ИГРА ЗАВЕРШЕНА. ПОБЕДИТЕЛЬ', igrok1)
            break
        elif n1 < n2:
          print('ВЫИГРАЛ', igrok2)
          list2.insert(0, 1)
          count2 = list2.count(1)
          print(igrok2, count2)
          if count2 < win:
            print('Следующая игра')
          else:
            print('ИГРА ЗАВЕРШЕНА. ПОБЕДИТЕЛЬ', igrok2)
            break
        else:
          print('Ничья')