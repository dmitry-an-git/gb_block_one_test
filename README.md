# Описание 

Цель программы - создание нового массива строк на основе массива строк, задаваемого пользователем, путем отбора элементов с длиной менее четырех символов.

Использованы следующие функции:
* *EnterArray()* - ввод массива пользователем
* *ProcessArray()* - обработка массива
* *PrintArray()* - вывод массива в консоли

От пользователя требуется задать в консоли произвольный массив строк с разделением элементов пробелами.

Функция *ProcessArray()* ведет подсчет подходящих элементов, после чего создвает новый массив нужной длины и заполняет его подходящими элементами.

В итоге программа выводит получившийся массив в консоль.

Блок-схема программы (с упрощенными *EnterArray()* и *PrintArray()*):

![][chart]

[chart]: block_diagram.png