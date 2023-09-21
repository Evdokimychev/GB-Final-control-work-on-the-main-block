## Задача:
 ### Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 
 Ссылки:
 [Блок-схема](Task/1.drawio.png)  [Код](Task/Program.cs)

 ### Решение задачи:
 #### 1. Запрашиваем данные у пользователя. 
 #### 2. Обьявляем два массива. 
 #### 3. Применяем метод void,используем цикл for, в котором проверяем соответствие длинне массива. 
 #### Внутри цикла проверяем условие меньше или равно 3 символам, если да, то элемент первого массива заносится в count элемента второго массива. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1.
 #### 4. Печать массива.