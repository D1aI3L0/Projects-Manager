# Projects Manager

# Содержание

1. [Описание приложения](#intro)<br/>
2. [Составляющие проекта](#project_components)<br/>
   2.1 [Программные интерфейсы](#programm_interface)<br/>
   2.2 [Интерфейс пользователя](#user_interface)<br/>
   2.3 [Характеристики пользователей](#users_characteristics)<br/>
3. [Основной функционал проекта](#main_functional)<br/>
4. [Графический материал](#graph_materials)<br/>
   4.1 [Диаграммы](#graph_materials)<br/>
   4.2 [Скриншоты](#graph_materials)<br/>
5. [Системные требования](system_requirments)<br/>
   5.1 [Функциональные требования](#functionla_requirments)<br/>
   5.2 [Нефункциональные требования](#unfunctionla_requirments)<br/>


<a name="intro"></a>

# 1 Описание приложения

Приложение "Projects manager" предназначено для быстрого доступа пользователя к проектам на персональном компьютере.
Оно позволяет пользователю быстро добавить проект, указав к нему путь в системе и язык программирования, на котором этот проект разрабатывается. Также можно оставить краткое описание, чтобы не приходилось долго вспоминать, что это за проект, и ссылку на git-репозиторий.
После можно открывать папку с проектом в системе или переходить на git-репозиторий через приложение. 

<a name="project_components" />

# 2 Составляющие проекта

<a name="programm_interface" />

## 2.1 Программные интерфейсы

Приложение разрабатывается под операционную систему Windows на языке C# и использует следующие программные интерфейсы:

   - **.Net Framework** это среда для разработки программного обеспечения, которая позволяет создавать и запускать приложения. Она предоставляет набор классов и интерфейсов для работы с различными аспектами операционной системы.

Для хранения данных о сохраненных проектах будет использоваться реестр Windows.

<a name="user_interface" />

## 2.2 Интерфейс пользователя

В состав пользовательского интерфейса Projects Manager входят:

   - **Список проектов** - в нем отображаются все сохраненные в приложении проекты
   - **Панель инструментов** - позволяет изменять, удалять существующие проекты и добавлять новые
   - **Рабочую область** -  при выборе проекта показывается информация о нём (путь в системе, описание, ссылка на git), занимает большую часть экрана

<a name="users_characteristics" />

## 2.3 Характеристики пользователя

Единственным ограничением для пользователя станет уровень системного доступа к файлам на устройстве.

<a name="main_functional" />

# 3 Основной функционал проекта

Приложение Projects Manager включает в себя несколько основный функций:

- Работа со своими проектами
    - Добавление нового проекта
    - Удаление проекта из приложения
    - Редактирование данных о проекте
    - Открытие проектов
    - Открытие ссылки на git-репозиторий
- Работа с интерфейсом программы
    - Изменение языка

<a name="graph_materials" />

# 4 Графический материал

## 4.1 Диаграммы

[Диаграммы](https://github.com/D1aI3L0/Projects-Manager)

## 4.2 Скриншоты

[Скриншоты](https://github.com/D1aI3L0/Projects-Manager)

<a name="system_requirments" />

# 5 Системные требования

   - ОС Windows 10/11
   - .Net 4.7.2+

<a name="functionla_requirments" />
     
## 5.1 Функциональные требования

   - Добавление/удаление/изменение проектов
   - Сортировка проектов по различным критериям
   - Открытие проектов
   - Сортировка проектов по различным критерия
   - Интуитивно понятный и удобный интерфейс

<a name="unfunctionla_requirments" />

## 5.1 Нефункциональные требования

Для реализации проекта необходимо использовать язык программирования C# и фреймворк .NET Framework 4.7.2.
