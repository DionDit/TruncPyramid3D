# TruncPyramid3D

![Main Screenshot](https://sun9-61.userapi.com/impg/4ErwUIYorghcygzYyIoWJaq_XiEs0fTquQIGQg/Wl3b736Udkw.jpg?size=682x389&quality=95&sign=ac2b4db50c4f4ca7f6ebea75d1a97a43&type=album)

Программа для работы с 3D-усечённой пирамидой в WPF с использованием HelixToolkit.WPF. Позволяет изменять вид камеры, перемещаться по координатам, масштабировать объект, очищать историю изменений и менять цвет.

## 📌 Возможности

- Изменение положения камеры (вращение, перемещение, масштабирование)
- Перемещение усечённой пирамиды в пространстве
- Изменение масштаба объекта
- Очистка истории изменений
- Изменение цвета модели

## 🚀 Установка и запуск

### 1️⃣ Установка зависимостей

Перед сборкой убедитесь, что у вас установлены:

- .NET Core SDK 6.0+ или .NET Framework 4.7.2+
- Visual Studio 2022 с поддержкой WPF
- HelixToolkit.WPF

Установите HelixToolkit.WPF через NuGet:
```sh
Install-Package HelixToolkit.Wpf
```
Или добавьте в csproj:
```sh
<PackageReference Include="HelixToolkit.Wpf" Version="2.24.0" />
```
### 2️⃣ Запуск проекта

#### 1. Склонируйте репозиторий:
  ```sh
   git clone https://github.com/DionDit/TruncPyramid3D.git
   cd TruncPyramid3D
   ```
   
#### 2. Откройте проект в Visual Studio.

#### 3. Соберите решение и запустите приложение (**Ctrl+F5**).

---

## 🏗 Архитектура проекта

### 📌 Основные технологии:

- WPF (Windows Presentation Foundation) — основной UI-фреймворк.
- HelixToolkit.WPF — библиотека для 3D-рендеринга.
- MVVM (Model-View-ViewModel) — архитектурный паттерн.
- XAML — разметка пользовательского интерфейса.

### 📦 Компоненты проекта:

#### 1. View (Views/Windows/MainWindow.xaml)
   - Определяет интерфейс и компоненты управления.
#### 2. ViewModel (ViewModels/MainWindowViewModel.cs)
   - Обрабатывает пользовательские команды.
   - Управляет состоянием 3D-объекта.
   - Обеспечивает логику изменения цвета, масштаба и позиции.
#### 3. Model (Models/Geometry/TruncatedPyramidModel3D.cs)
   - Определяет 3D-геометрию усечённой пирамиды.
---

## 📝 Инструкция пользователя

### 📌 Управление камерой

- Колесо мыши — зум.
- Правая кнопка мыши — перемещние.
- Правая кнопка мыши + движение — панорамирование.

### 📌 Управление объектом

- A / D / Q / Z — перемещение по координатам.
- A / D - лево и право
- Q / Z — вверх и вниз.
- W / S - — увеличение/уменьшение масштаба.
---

## ✏️ Описание коммитов
| Название | Описание                                                        |
|----------|-----------------------------------------------------------------|
| build	   | Сборка проекта                                                  |
| sec      | Безопасность, уязвимости                                        |
| docs	   | Обновление документации                                         |
| feat	   | Добавление нового функционала                                   |
| fix	     | Исправление ошибок                                              |
| perf	   | Изменения направленные на улучшение производительности          |
| refactor | Правки кода без исправления ошибок или добавления новых функций |
| style	   | Правки по кодстайлу (табы, отступы, точки, запятые и т.д.)      |
| test	   | Добавление тестов                                               |


## 🤝 Вклад в проект

Если у вас есть идеи или улучшения, создавайте Issue или отправляйте Pull Request!

📩 Контакты: [GitHub](https://github.com/DionDit)

⭐️ Поставьте звезду репозиторию, если вам понравился проект! 🚀
