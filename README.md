# План реализация проекта "Только факты"

* [x] Регистрация репозитория github.com
* [x] Создание проекта и его подготовка к разработке
    * [x] Настройка логирования в log-файл
    * [x] Реализация "вход/выход" на сайте
* [x] Настройка добавления учетной записи при создании новой базы (SEED)
* [x] Создание сущностей (классов) и конфигрурирование сущностей через fluent API (EntityTypeConfiguration)
    * [x] Fact
    * [x] Tag
    * [x] Notification
* [x] Создание EF-миграции и базы данных
* [x] Настройка возможности переноса данных из старой БД в новую БД
* [x] Создание ViewModels для сущностей и настройка маппинга (Automapper)
* [ ] Изменение шаблонов от Microsoft.AspNetCore.Identity UI
* [ ] Шаблоны ASP.NET MVC (_Layout) и управление ими
* [ ] Реализация в ApplicationDbContext автоматическое обновление свойств CreatedAt, UpdatedAt, CreatedBy, UpdatedBy (унаследованных от типа Auditable)
* [ ] Определить маршруты для MVC
* [ ] Mediatr: Инфраструктура для Notification
  * [ ] Mediatr: NotificationBase
  * [ ] Mediatr: NotificationHandlerBase
  * [ ] Mediatr: ErrorNotification
  * [ ] Mediatr: ErrorNotificationHandler
  * [ ] Mediatr: FeedbackNotification
  * [ ] Mediatr: FeedbackNotificationHandler
* [ ] Объединение и минификация статических ресурсов в ASP.NET Core 
* [ ] Создание главной страницы (без разбиение на страницы)
  * [ ] Метод в контроллере FactsController
  * [ ] Mediatr: GetPagedRequest
  * [ ] Mediatr: GetPagedResponse
* [ ] TagHelper: Создание pager: IPagedListTagHelperService, PagerData, PagedListHelper
* [ ] Подключение Pager на главную страницу
* [ ] Страница детального просмотра выбранного факта
  * [ ] Рефакторинг partial view отображения факта на главной странице
  * [ ] Создание partial представлений "мелких" компонентов
* [ ] Страница "Обратная связь" 
  * [ ] Ообавление записей в список уведомлений (Notification)
  * [ ] Mediatr: PostNotificationRequest
  * [ ] Mediatr: PostNotificationResponse
* [ ] Администратор: Страница "панель управления" (навигатор управления)
* [ ] Администратор: Страница "добавление факта"
* [ ] Администратор: Страница "редактирования факта"
* [ ] Администратор: Страница "удаления факта"
* [ ] Администратор: Реализация постраничного просмотра списка сообщений (Notification)
* [ ] Администратор: Страница "отправки почтового сообщения"
* [ ] HostedService: Сработка по расписанию (Cron)
  * [ ] Отправка почты. Создание IEmailService
  * [ ] INotificationProvider обработчик Notification, отправка сообщений и обновление статуса отправки
  * [ ] Реализация BackgroundWorker для отправки почтовых писем из таблицы Notification