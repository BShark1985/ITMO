print('------------------')
print('Работа со строками')
print('------------------')
# Работа со строками 1
string1 = "This is a string."
string2 = " This is another string."

# Работа со строками 2
print(string1 + string2)

# Работа со строками 3
print(len(string1))  # - определяет длину строки;
print(string1.title())  # - преобразует первый символ каждого слова в строке к верхнему регистру;
print(string1.lower())  # - символы строки преобразуются к нижнему регистру;
print(string1.upper())  # - символы строки преобразуются к верхнему регистру;
print(string1.rstrip())  # – удаляются пробелы в конце строки;
print(string2.lstrip())  # – удаляются пробелы в начале строки;
print(string2.strip())  # - удаляются пробелы с обоих концов;
print(string1.strip('T.'))  # - удаляются с обоих концов указанные символы в параметре функции.

# Работа со строками 4
d = "qwerty"
ch = d[2]  # извлекается символ ‘e’
print(ch)

# Работа со строками 5
myList = [1, 2, 3, 4, 5, 6, 7, 8, 9]
print(myList[::])
chm1 = myList[1:3]

# Работа со строками 6
chm2 = myList[1:]
chm3 = myList[:3]
chm4 = myList[:]
chm5 = myList[1:5:2]
print(chm1)
print(chm2)
print(chm3)
print(chm4)
print(chm5)

# Работа со строками 7
myList[2] = 'o'
print(myList[::])

print('----------------')
print('Работа с числами')
print('----------------')
# Работа с числами 1
num1 = int(10)
num2 = int(5)

# Работа с числами 2
print(num1 / num2)
print(num1 % num2)
print(num1 ** num2)

# Работа с числами 3
print(string1 + str(num1))

print('---------------------')
print('Преобразование данных')
print('---------------------')
# Преобразование данных 1
param = "string" + str(15)
print(param)

# Преобразование данных 2  >>РАСКОММЕНТИРОВАТЬ<< >>РАСКОММЕНТИРОВАТЬ<< >>РАСКОММЕНТИРОВАТЬ<<
# n1 = input("Enter the first number: ")
# n2 = input("Enter the second number: ")
# n3 = float(n1) + float(n2)
# print(n1 + " plus " + n2 + " = ", "{:7.2f}".format(n3))

# Преобразование данных. Форматирование строк 1-2
a = 1/3
print("{:7.3f}".format(a))

# Преобразование данных. Форматирование строк 3
a = 2/3
b = 2/9
print("{:7.3f} {:7.3f}".format(a, b))
print("{:10.3e} {:10.3e}".format(a, b))

# Преобразование данных. Форматирование строк 4
# В программе прошлого раздела, (запрашивающую у пользователя два числа
# и реализующую их сложение) измените способ вывода результата –
# примените функцию format()

print('------')
print('Списки')
print('------')
#1
list1 = [82,8,23,97,92,44,17,39,11,12]
#2
print (dir(list1))
#3
help(list1.insert)
help(list1.append)
help(list1.sort)
help(list1.remove)
help(list1.reverse)
#4

#5
list1.append(0)
print(list1)
#6
list1.insert(0, 1)
print(list1)
#7
list1.pop(0)
print(list1)
#8
list1.pop()
print(list1)

# Сортировка элементов списка
#1
list1.sort(reverse=True)
#2
print(list1)
#3
list2 = [3,5,6,2,33,6,11]
#4
lis = sorted(list2)
#5
print(list2)
print(lis)

print('-------')
print('Кортежи')
print('-------')
#1
print (dir(tuple))
#2
help(tuple.index)
help(tuple.count)
#3
seq = (2,8,23,97,92,44,17,39,11,12)
#4
print(seq.count(8))
print(seq.index(44))
#5
listseq = list(seq)
#6
print(type(listseq))

print('-------')
print('Словари')
print('-------')

#1
D = {'food': 'Apple', 'quantity': 4, 'color': 'Red'}
print(D['quantity'])
#2
D['food']
D['quantity'] += 10
print(D)
#3
dp = {}

print('---------------------------')
print('Вложенность хранения данных')
print('---------------------------')

#1
rec = {'name': {'firstname': 'Bob', 'lastname': 'Smith'}, 'job': ['dev', 'mgr'], 'age': 25}
#2
print(rec['name'])
print(rec['name']['lastname'])
print(rec['job'])
#3
rec['job'].append('janitor')
print(rec)
#4
print((rec['name']['firstname']), (rec['name']['lastname']), "возрастом " ,(rec['age']), "обладает следующими профессиями: ",(rec['job']))