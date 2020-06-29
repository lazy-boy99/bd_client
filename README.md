# Aircraft client
Приложение написано на языке C#;\
Необходимые программы: \
Windows OS, .net framework 4.8.0, Oracle database, sqldeveloper(опционально)\
Установка: \
0.Для того чтобы выполнить инсталляцию приложение выполните команду git clone. \
1.Для корректной работы с базой данных создайте/ зайдите в oracle database, создайте новую схему и выполните в строгом порядке следующие скрипты из папки \
src:scripts.sql,autoincrement_triggers.sql,triggers.sql,export.sql \
\
Альтернативные способы:\
/* если имя пользователя специфичное относительно стандартного(db), прийдется изменить все вхождения "db" в скрипте sql/export1.sql на корректное имя */ \
  1.Зайдите в sqldeveloper на панели интерфейса выберите file->data modeler-> import->dll и выберите src/export1.sql файл\
  2.Зайдите в СУБД посредством sqlplus, выполните команды перечисленые в src/export1.sql \
  \
2. Перейдете в папку setup\Application Files\Main_1_0_0_1\Resource выберите файл config.txt и откройте его в текстовом редакторе. \
Впишите туда корректные данные вашей базы данных в соответствие Key=Value. \
3.Зайдите в папку setup и нажмите на скрипт setup.exe, таким образом будет выполнена установка програмы, для запуска также нажимайте на setup.exe\
\
Аккаунты и роли: \
123	123	Директор\
1234	1234	Директор по производству\
12345	12345	Директор научного персонала\
11	11	Директор технического персонала\
111	111	Директор рабочего персонала\
12	12	Ответственный за лабораторное оборудование
