# ToplivoCodeFirst - находится в процессе разработки.

Проект MS Visual Studio 2015 содержит относительно простое MVC 5 ASP .NET приложение. Может быть полезен в качестве примера для выполнения лабораторных работ и курсового проекта по дисциплине "Разработка приложений баз данных для информационных систем" для студентов специальности "Информационные системы и технологии".

Для работы с реляционной базой данных TOPLIVO СУБД MS SQL Server использовани ОRM фреймворк Entity Framework 6.1 в режиме CodeFirst. За непосредственное взаимодействие с базой данных отвечает класс контекста ToplivoContext. Таблицам базы данных сопоставляются объекты классов Fuel, Tank, Operation. 
Entity Framework на основе классов Fuel, Tank, Operation создает в базе данных три таблицы:  Fuels (виды топлива), Tanks (список емкостей для хранения), Operations (факты совершения операций прихода, расхода топлива в емкостях). 

Проект содержит (на выбор) два разных инициализатора базы данных, которые генерирует наборы тестовых записей в таблицах Fuels, Tanks и Operations: один использует объекты и методы классов EF, другой - запускает SQL скрипт.

Типовые операции с данными (CRUD) описаны в интерфейсе IRepository. На основе интерфейса IRepository реализованы классы FuelRepository, TankRepository, OperationRepository, которые определяют специфику реализации операций с данными применительно к соответствующим  объектам (таблицам).

Для упрощения работы с различными репозиториями реализован паттерн Unit of Work (класс UnitOfWork). Это позволяет гарантировать, что все репозитории будут использовать один и тот же контекст данных. Доступ к конкретному репозитарию в контроллерах осуществляется как вызов саойства экземпляра UnitOfWork.

Отображение и работа с табличными данными реализованы двумя способами: путем динамического формирования страниц на стороне сервера и с использованием клиентского JavaScript элемента jqGrid  (соответствующий пакет Nuget называется jQuery.jqGrid,  рабочий проект можно скачать по ссылке: https://github.com/sourabhsomani/jqGrid-Using-MVC, а его описание: http://www.c-sharpcorner.com/article/performing-crud-operation-using-jqgrid-in-Asp-Net-mvc/)


