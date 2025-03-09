using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Manipulator3D.MVVM.Models.Geometry
{
    public class TruncatedPyramidModel3D
    {
        /// <summary>
        /// Группа трансформаций.
        /// </summary>
        private Transform3DGroup _transformGroup;

        /// <summary>
        /// 3D Модель.
        /// </summary>
        private ModelVisual3D _model;

        /// <summary>
        /// Материал модели.
        /// </summary>
        private DiffuseMaterial _materialModel;

        /// <summary>
        /// 3D Модель.
        /// </summary>
        public ModelVisual3D Model { get; set; }

        /// <summary>
        /// Материал модели.
        /// </summary>
        public DiffuseMaterial MaterialModel { get; set; }

        /// <summary>
        /// Конструктор класса <see cref="TruncatedPyramidModel3D"./>
        /// </summary>
        public TruncatedPyramidModel3D()
        {
            _transformGroup = new Transform3DGroup();
            MaterialModel = new DiffuseMaterial(new SolidColorBrush(Colors.Blue));
            Model = new ModelVisual3D { Content = CreatePyramid() };
            Model.Transform = _transformGroup;
        }

        /// <summary>
        /// Создание усеченной пирамиды.
        /// </summary>
        /// <returns></returns>
        private Model3D CreatePyramid()
        {
            // Экземпляр класса для хранения данных о геометрии.
            MeshGeometry3D mesh = new MeshGeometry3D();

            // Вершины пирамиды.
            List<Point3D> Vertexes = new List<Point3D>()
            {
                // Основание пирамиды
                new Point3D(0, 0, 0),   
                new Point3D(2, 0, 0),
                new Point3D(1, 0, 2),
                // Верхняя часть пирамиды
                new Point3D(0.5, 1, 0.5), 
                new Point3D(1.5, 1, 0.5),
                new Point3D(1, 1, 1.5)
            };
            // Индексы для соединения вершин
            List<int> Indexes = new List<int>()
            {
                // Нижняя грань (двойной рендер)
                0,1,2,  2,1,0, 
                // Верхняя грань
                3,4,5,  5,4,3,  
                // Боковые грани (двойной рендер)
                0,1,4, 4,3,0,   4,1,0, 3,4,0, 
                1,2,5, 5,4,1,   5,2,1, 4,5,1,
                2,0,3, 3,5,2,   3,0,2, 5,3,2
            };
            
            //Добавление вершин и индексов
            Vertexes.ForEach(x => mesh.Positions.Add(x));
            Indexes.ForEach(x => mesh.TriangleIndices.Add(x));

            return new GeometryModel3D(mesh, MaterialModel);
        }

        /// <summary>
        /// Перемещение по оси координат X+.
        /// </summary>
        public void MoveXPlus() => _transformGroup.Children.Add(new TranslateTransform3D(0.5, 0, 0));
        /// <summary>
        /// Перемещение по оси координат X-.
        /// </summary>
        public void MoveXMinus() => _transformGroup.Children.Add(new TranslateTransform3D(-0.5, 0, 0));
        /// <summary>
        /// Вращение по оси координат Y.
        /// </summary>
        public void RotateY() => _transformGroup.Children.Add(new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 1, 0), 30)));

        /// <summary>
        /// Приближение.
        /// </summary>
        public void ScaleUp() => _transformGroup.Children.Add(new ScaleTransform3D(1.2, 1.2, 1.2));

        /// <summary>
        /// Отдаление.
        /// </summary>
        public void ScaleDown() => _transformGroup.Children.Add(new ScaleTransform3D(0.8, 0.8, 0.8));

        /// <summary>
        /// Отчистка истории трансформаций.
        /// </summary>
        public void ResetTransform() => _transformGroup.Children.Clear();
    }
}