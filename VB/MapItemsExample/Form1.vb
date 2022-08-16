Imports DevExpress.XtraMap
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsFormsApplication3

    Public Partial Class Form1
        Inherits Form

        Const imageFilePath As String = "../../logo.png"

        Private ReadOnly Property VectorLayer As VectorItemsLayer
            Get
                Return CType(map.Layers("VectorLayer"), VectorItemsLayer)
            End Get
        End Property

        Private ReadOnly Property ItemStorage As MapItemStorage
            Get
                Return CType(VectorLayer.Data, MapItemStorage)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs)
#Region "#MapDotExample"
            ItemStorage.Items.Add(New MapDot() With {.Location = New GeoPoint(-10, 10), .Size = 18, .Stroke = Color.Blue})
#End Region  ' #MapDotExample
#Region "#MapEllipseExample"
            ItemStorage.Items.Add(New MapEllipse() With {.Location = New GeoPoint(40, 40), .Height = 300, .Width = 600})
#End Region  ' #MapEllipseExample
#Region "#MapLineExample"
            ItemStorage.Items.Add(New MapLine With {.Point1 = New GeoPoint(-30, 20), .Point2 = New GeoPoint(-35, 25), .Stroke = Color.Red, .StrokeWidth = 4})
#End Region  ' #MapLineExample
#Region "#MapCalloutExample"
            ItemStorage.Items.Add(New MapCallout() With {.Location = New GeoPoint(10, 10), .Text = "This is a MapCallout object"})
#End Region  ' #MapCalloutExample
#Region "#MapPathExample"
            Dim path = New MapPath()
            Dim segment = New MapPathSegment()
            segment.Points.AddRange(New GeoPoint() {New GeoPoint(20, 20), New GeoPoint(20, 30), New GeoPoint(30, 30)})
            path.Segments.Add(segment)
            segment = New MapPathSegment()
            segment.Points.AddRange(New GeoPoint() {New GeoPoint(30, 32), New GeoPoint(20, 32), New GeoPoint(20, 42)})
            path.Segments.Add(segment)
            ItemStorage.Items.Add(path)
#End Region  ' #MapPathExample
#Region "#MapPolygonExample"
            Dim polygon = New MapPolygon()
            polygon.Points.AddRange(New GeoPoint() {New GeoPoint(70, 80), New GeoPoint(75, 90), New GeoPoint(75, 130)})
            ItemStorage.Items.Add(polygon)
#End Region  ' #MapPolygonExample
#Region "#MapPolylineExample"
            Dim polyline = New MapPolyline() With {.StrokeWidth = 4, .Stroke = Color.Yellow}
            polyline.Points.AddRange(New GeoPoint() {New GeoPoint(-29, 130), New GeoPoint(-40, 140), New GeoPoint(-20, 150)})
            ItemStorage.Items.Add(polyline)
#End Region  ' #MapPolylineExample
#Region "#MapPushpinExample"
            ItemStorage.Items.Add(New MapPushpin() With {.Location = New GeoPoint(70, -100), .Text = "1"})
#End Region  ' #MapPushpinExample
#Region "#MapRectangleExample"
            ItemStorage.Items.Add(New MapRectangle() With {.Location = New GeoPoint(-70, -100), .Width = 500, .Height = 750})
#End Region  ' #MapRectangleExample
#Region "#MapCustomElementExample"
            Dim customElement = New MapCustomElement() With {.Location = New GeoPoint(50, 50), .Text = "This is a MapCustomElement object"}
            Dim image = New Bitmap(imageFilePath)
            customElement.Image = New Bitmap(image, New Size(40, 40))
            ItemStorage.Items.Add(customElement)
#End Region  ' #MapCustomElementExample
#Region "#MapBubbleExample"
            ItemStorage.Items.Add(New MapBubble() With {.Location = New GeoPoint(30, 20), .Value = 400, .Argument = "A", .Size = 100})
#End Region  ' #MapBubbleExample
#Region "#MapPieExample"
            Dim pie = New MapPie() With {.Location = New GeoPoint(-20, -30), .Size = 100}
            pie.Segments.AddRange(New PieSegment() {New PieSegment() With {.Argument = "A", .Value = 2}, New PieSegment() With {.Argument = "B", .Value = 3}, New PieSegment() With {.Argument = "C", .Value = 4}})
            ItemStorage.Items.Add(pie)
#End Region  ' #MapPieExample
        End Sub
    End Class
End Namespace
