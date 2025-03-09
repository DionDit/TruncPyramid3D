using HelixToolkit.Wpf;
using Manipulator3D.MVVM.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Manipulator3D.MVVM.Models;
using System.Windows.Media.Media3D;
using System.Windows.Input;
using Manipulator3D.MVVM.Models.Commands;
using System.Windows.Controls;
using System.Windows.Media;

namespace Manipulator3D.MVVM.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        /// <summary>
        /// Отображение 3D пространства.
        /// </summary>
        public HelixViewport3D View3D { get; set; }

        /// <summary>
        /// Список доступных цветов для модели.
        /// </summary>
        public List<string> ModelColors { get; set; } = new List<string>()
        {
            "Красный", "Зеленый",  "Синий"
        };

        /// <summary>
        /// Текущий цвет модели.
        /// </summary>
        public string CurrentColor { get; set; }

        /// <summary>
        /// Камера для модели.
        /// </summary>
        public MVVM.Models.Geometry.Camera Camera { get; set; }

        /// <summary>
        /// 3D Объект.
        /// </summary>
        public MVVM.Models.Geometry.TruncatedPyramidModel3D Model { get; set; }

        /// <summary>
        /// Конструктор класса <see cref="MainWindowViewModel"./>
        /// </summary>
        public MainWindowViewModel()
        {
            Camera = new MVVM.Models.Geometry.Camera();
            Model = new MVVM.Models.Geometry.TruncatedPyramidModel3D();
        }

        /// <summary>
        /// Команда для перемещения по оси координат X+.
        /// </summary>
        public ICommand MoveXPlus
        {
            get => new DelegateCommand((obj) =>
            {
                Model.MoveXPlus();
            });
        }

        /// <summary>
        /// Команда для перемещения по оси координат X-.
        /// </summary>
        public ICommand MoveXMinus
        {
            get => new DelegateCommand((obj) =>
            {
                Model.MoveXMinus();
            });
        }

        /// <summary>
        /// Команда для вращения по оси координат Y.
        /// </summary>
        public ICommand RotateY
        {
            get => new DelegateCommand((obj) =>
            {
                Model.RotateY();
            });
        }

        /// <summary>
        /// Команда для приближения.
        /// </summary>
        public ICommand ScaleUp
        {
            get => new DelegateCommand((obj) =>
            {
                Model.ScaleUp();
            });
        }

        /// <summary>
        /// Команда для отдаления.
        /// </summary>
        public ICommand ScaleDown
        {
            get => new DelegateCommand((obj) =>
            {
                Model.ScaleDown();
            });
        }

        /// <summary>
        /// Команда для отчистки истории трансформаций.
        /// </summary>
        public ICommand ResetTransform
        {
            get => new DelegateCommand((obj) =>
            {
                Model.ResetTransform();
            });
        }

        /// <summary>
        /// Команда для фронтального отображения камеры.
        /// </summary>
        public ICommand SetFrontView
        {
            get => new DelegateCommand((obj) =>
            {
                Camera.OrthoCamera.Position = new Point3D(0, 0, 5);
                Camera.OrthoCamera.LookDirection = new Vector3D(0, 0, -5);
                Camera.CurrentCamera = Camera.OrthoCamera;
                View3D.Camera = Camera.CurrentCamera;
            });
        }

        /// <summary>
        /// Команда для перспективного отображения камеры.
        /// </summary>
        public ICommand SetPerspectiveView
        {
            get => new DelegateCommand((obj) =>
            {
                Camera.PerspectiveCamera.Position = new Point3D(3, 3, 5);
                Camera.PerspectiveCamera.LookDirection = new Vector3D(-3, -3, -5);
                Camera.CurrentCamera = Camera.PerspectiveCamera;
                View3D.Camera = Camera.CurrentCamera;
            });
        }

        /// <summary>
        /// Команда для косоугольного отображения камеры.
        /// </summary>
        public ICommand SetObliqueView
        {
            get => new DelegateCommand((obj) =>
            {
                Camera.OrthoCamera.Position = new Point3D(3, 3, 5);
                Camera.OrthoCamera.LookDirection = new Vector3D(-3, -3, -5);
                Camera.OrthoCamera.UpDirection = new Vector3D(0, 1, 1);
                Camera.CurrentCamera = Camera.OrthoCamera;
                View3D.Camera = Camera.CurrentCamera;
            });
        }

        /// <summary>
        /// Команда для изменения цвета модели.
        /// </summary>
        public ICommand ChangeModelColor
        {
            get => new DelegateCommand((obj) =>
            {
                switch (CurrentColor)
                {
                    case "Красный":
                        Model.MaterialModel.Brush = new SolidColorBrush(Colors.Red);
                        break;
                    case "Зеленый":
                        Model.MaterialModel.Brush = new SolidColorBrush(Colors.Green);
                        break;
                    case "Синий":
                        Model.MaterialModel.Brush = new SolidColorBrush(Colors.Blue);
                        break;
                }
            });
        }
    }
}