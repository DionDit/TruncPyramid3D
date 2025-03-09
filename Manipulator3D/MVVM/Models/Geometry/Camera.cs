using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Manipulator3D.MVVM.Models.Geometry
{
    /// <summary>
    /// Класс камеры.
    /// </summary>
    public class Camera
    {
        /// <summary>
        /// Перспективное изображение
        /// </summary>
        private PerspectiveCamera _perspectiveCamera;

        /// <summary>
        /// Ортографическое изображение
        /// </summary>
        private OrthographicCamera _orthoCamera;

        /// <summary>
        /// Перспективное изображение
        /// </summary>
        public PerspectiveCamera PerspectiveCamera { get; set; }

        /// <summary>
        /// Ортографическое изображение
        /// </summary>
        public OrthographicCamera OrthoCamera { get; set; }

        /// <summary>
        /// Выбранная камера.
        /// </summary>
        public ProjectionCamera CurrentCamera { get; set; }

        /// <summary>
        /// Конструктор класса <see cref="Camera"./>
        /// </summary>
        public Camera()
        {
            PerspectiveCamera = new PerspectiveCamera()
            {
                Position = new Point3D(3, 3, 5),
                LookDirection = new Vector3D(-3, -3, -5),
                UpDirection = new Vector3D(0, 1, 0),
                FieldOfView = 45
            };

            OrthoCamera = new OrthographicCamera()
            {
                Position = new Point3D(3, 3, 5),
                LookDirection = new Vector3D(-3, -3, -5),
                UpDirection = new Vector3D(0, 1, 0),
                Width = 5
            };

            CurrentCamera = PerspectiveCamera;
        }
    }
}