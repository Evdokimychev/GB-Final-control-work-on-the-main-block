## Задача:
 ### Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

 Примеры:
`[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]`
`[“1234”, “1567”, “-2”, “computer science”] → [“-2”]`
`[“Russia”, “Denmark”, “Kazan”] → []`

 ### Для выполнения проверочной работы необходимо:

 #### 1. Создать репозиторий на GitHub
 #### 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
 #### 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
 #### 4. Написать программу, решающую поставленную задачу
 #### 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)
 
 Ссылки:
 [Блок-схема](1.drawio.png)
 [Код](Task/Program.cs)

 ### Решение задачи:
 #### 1. Запрашиваем данные у пользователя. 
 #### 2. Обьявляем два массива. 
 #### 3. Применяем метод void,используем цикл for, в котором проверяем соответствие длинне массива. 
 #### Внутри цикла проверяем условие меньше или равно 3 символам, если да, то элемент первого массива заносится в count элемента второго массива. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1.
 #### 4. Печать массива.