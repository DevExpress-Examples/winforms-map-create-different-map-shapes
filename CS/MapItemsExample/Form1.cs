using DevExpress.XtraMap;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication3 {
    public partial class Form1 : Form {
        const string imageFilePath = @"../../logo.png";
        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e) {
            #region #MapDotExample
            ItemStorage.Items.Add(new MapDot() { Location = new GeoPoint(-10, 10), Size = 18, Stroke = Color.Blue });
            #endregion #MapDotExample

            #region #MapEllipseExample
            ItemStorage.Items.Add(new MapEllipse() { Location = new GeoPoint(40, 40), Height = 300, Width = 600 });
            #endregion #MapEllipseExample

            #region #MapLineExample
            ItemStorage.Items.Add(new MapLine { Point1 = new GeoPoint(-30, 20), Point2 = new GeoPoint(-35, 25), Stroke = Color.Red, StrokeWidth = 4 });
            #endregion #MapLineExample

            #region #MapCalloutExample
            ItemStorage.Items.Add(new MapCallout() { Location = new GeoPoint(10, 10), Text = "This is a MapCallout object" });
            #endregion #MapCalloutExample

            #region #MapPathExample
            var path = new MapPath();
            var segment = new MapPathSegment();
            segment.Points.AddRange(new GeoPoint[] {
                new GeoPoint(20, 20),
                new GeoPoint(20, 30),
                new GeoPoint(30, 30) });
            path.Segments.Add(segment);
            segment = new MapPathSegment();
            segment.Points.AddRange(new GeoPoint[] {
                new GeoPoint(30, 32),
                new GeoPoint(20, 32),
                new GeoPoint(20, 42) });
            path.Segments.Add(segment);
            ItemStorage.Items.Add(path);
            #endregion #MapPathExample

            #region #MapPolygonExample
            var polygon = new MapPolygon();
            polygon.Points.AddRange(new GeoPoint[] {
                new GeoPoint(70,80),
                new GeoPoint(75,90),
                new GeoPoint(75,130)
            });
            ItemStorage.Items.Add(polygon);
            #endregion #MapPolygonExample

            #region #MapPolylineExample
            var polyline = new MapPolyline() { StrokeWidth = 4, Stroke = Color.Yellow };
            polyline.Points.AddRange(new GeoPoint[] {
                new GeoPoint(-29,130),
                new GeoPoint(-40,140),
                new GeoPoint(-20,150)
            });
            ItemStorage.Items.Add(polyline);
            #endregion #MapPolylineExample

            #region #MapPushpinExample
            ItemStorage.Items.Add(new MapPushpin() { Location = new GeoPoint(70, -100), Text = "1" });
            #endregion #MapPushpinExample

            #region #MapRectangleExample
            ItemStorage.Items.Add(new MapRectangle() { Location = new GeoPoint(-70, -100), Width = 500, Height = 750 });
            #endregion #MapRectangleExample

            #region #MapCustomElementExample
            var customElement = new MapCustomElement() { Location = new GeoPoint(50, 50), Text = "This is a MapCustomElement object" };
            var image = new Bitmap(imageFilePath);
            customElement.Image = new Bitmap(image, new Size(40, 40));
            ItemStorage.Items.Add(customElement);
            #endregion #MapCustomElementExample

            #region #MapBubbleExample
            ItemStorage.Items.Add(new MapBubble() { Location = new GeoPoint(30, 20), Value = 400, Argument = "A", Size = 100 });
            #endregion #MapBubbleExample

            #region #MapPieExample
            var pie = new MapPie() { Location = new GeoPoint(-20, -30), Size = 100 };
            pie.Segments.AddRange(new PieSegment[] {
                new PieSegment(){ Argument = "A", Value = 2},
                new PieSegment(){ Argument = "B", Value = 3},
                new PieSegment(){ Argument = "C", Value = 4}
            });
            ItemStorage.Items.Add(pie);
            #endregion #MapPieExample

            #region #MapSplineExample
            var spline = new MapSpline() { StrokeWidth = 4, Stroke = Color.Green };
            spline.Points.AddRange(new GeoPoint[] {
                new GeoPoint(-37, 130.63),
                new GeoPoint(-50, 140.7),
                new GeoPoint(-32, 150.6)
            });
            ItemStorage.Items.Add(spline);
            #endregion #MapSplineExample

            map.ZoomToFitLayerItems(new LayerBase[] { VectorLayer });
        }

        private void openStreetMapDataProvider1_WebRequest(object sender, MapWebRequestEventArgs e) {
            e.UserAgent = "Sample OSM map example";
            e.Referer = "https://www.mycompanysite.com/";
        }
    }
}


