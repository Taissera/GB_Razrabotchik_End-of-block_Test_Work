Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться, что базовое знакомство с IT прошло успешно.
Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:
1.	Создать репозиторий на GitHub
2.	Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3.	Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4.	Написать программу, решающую поставленную задачу
5.	Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2,3 и 4 должны быть расположены в разных коммитах)

# Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

_*Примеры*_

* _["hello", "2", "world", ":-)"] -> ["2", ":-)"]_
* _["1234", "1567", "-2", "computer science"] -> ["-2"]_
* _["Russia", "Denmark", "Kazan"] -> []_

# Решение
## Репозиторий
1.	_Создать репозиторий на GitHub_

[Taissera/GB_Razrabotchik_End-of-block_Test_Work](https://github.com/Taissera/GB_Razrabotchik_End-of-block_Test_Work.git)

## Алгоритм
2.	_Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)_

![Алгоритм](.\Algoritm.png)

## README
3.	_Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)_

[README](README.md)

## Решение задачи
4.	Написать программу, решающую поставленную задачу

>см. Program.cs

## Контроль версий
5.	Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2,3 и 4 должны быть расположены в разных коммитах)

* ### initial commit: 

    - README.md

    - .gitignore

    - Proga (dotnet new console)

    **commit**: 70a0208164a8bc3bf2ff64019ba6c0b559cb50ce

* ### flowchart

    - update of README.md

    - Описание алгоритма решения

    **commit**: 533624b14dc4f08d317e65be215fbc78c0cd1e97

* ### solution
    - update of README.md

    - code & dotnet run (Program.cs)

    **commit**: 8b8b2cea45586ed6b302906e0191245ab691268e

* ###  ... несколько коммитов с форматированием README 
> эти коммиты не существенны для кода, только правки по оформлению README. Все эти коммиты также имеют комментарий "Final commit")

* ###  Final commit 
>(берём самый последний :-) )

