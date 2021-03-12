# SPbU Homework and Tests

| Semester 4 
| :-: 
| [Homework 1](#homework-1)
| [Homework 2](#homework-2)

## Homework 1
1. **Факториал.** [Solution](https://github.com/PavelSaltykov/Semester4/tree/main/Homeworks/HW1/Task1)  
Напишите на F# программу, считающую факториал. Подумайте, что делать, если ей передали отрицательное число.

2. **Фибоначчи.** [Solution](https://github.com/PavelSaltykov/Semester4/tree/main/Homeworks/HW1/Task2)  
Напишите программу, считающую (за линейное время) число Фибоначчи с заданным номером. Подумайте, что делать, если номер некорректный.

3. **Обращение списка.** [Solution](https://github.com/PavelSaltykov/Semester4/tree/main/Homeworks/HW1/Task3)  
Реализуйте функцию обращения списка, работающую за линейное время. Например, на списке `[1; 2; 3]` она должна возвращать `[3; 2; 1]`.

4. **Степени двойки.** [Solution](https://github.com/PavelSaltykov/Semester4/tree/main/Homeworks/HW1/Task4)  
Реализовать функцию, которая принимает на вход `n` и `m` и возвращает список из элементов  
`[2^n; 2^(n + 1); ...; 2^(n + m)]`.

5. **Поиск в списке.** [Solution](https://github.com/PavelSaltykov/Semester4/tree/main/Homeworks/HW1/Task5)  
Реализовать функцию, которая выдает первую позицию вхождения заданного числа в список.

## Homework 2
1. **map, filter, fold.** [Solution](https://github.com/PavelSaltykov/Semester4/tree/main/Homeworks/HW2/Task1)  
Реализовать три варианта функции, подсчитывающей количество четных чисел в списке (с использованием стандартных функций map, filter, fold). Использование рекурсии не допускается, зато нужен FsCheck для проверки функций на эквивалентность.

2. **map для деревьев.** [Solution](https://github.com/PavelSaltykov/Semester4/tree/main/Homeworks/HW2/Task2)  
Реализовать функцию, применяющую функцию к каждому элементу двоичного дерева и возвращающую новое двоичное дерево, каждый элемент которого — результат применения функции к соответствующему элементу исходного дерева (map для деревьев).

3. **Дерево разбора.** [Solution](https://github.com/PavelSaltykov/Semester4/tree/main/Homeworks/HW2/Task3)  
Посчитать значение дерева разбора арифметического выражения, заданного через вложенные discriminated union-ы.

4. **Простые числа.** [Solution](https://github.com/PavelSaltykov/Semester4/tree/main/Homeworks/HW2/Task4)  
Реализовать функцию, генерирующую бесконечную последовательность простых чисел.
