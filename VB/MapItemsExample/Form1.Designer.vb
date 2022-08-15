Namespace WindowsFormsApplication3

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim keyColorColorizer1 As DevExpress.XtraMap.KeyColorColorizer = New DevExpress.XtraMap.KeyColorColorizer()
            Dim argumentItemKeyProvider1 As DevExpress.XtraMap.ArgumentItemKeyProvider = New DevExpress.XtraMap.ArgumentItemKeyProvider()
            Me.imageTilesLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.openStreetMapDataProvider1 = New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapItemStorage1 = New DevExpress.XtraMap.MapItemStorage()
            Me.map = New DevExpress.XtraMap.MapControl()
            CType((Me.map), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.imageTilesLayer1.DataProvider = Me.openStreetMapDataProvider1
            AddHandler Me.openStreetMapDataProvider1.WebRequest, New DevExpress.XtraMap.MapWebRequestEventHandler(AddressOf Me.openStreetMapDataProvider1_WebRequest)
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette
            Me.vectorItemsLayer1.Colorizer = keyColorColorizer1
            Me.vectorItemsLayer1.Data = Me.mapItemStorage1
            Me.vectorItemsLayer1.Name = "VectorLayer"
            ' 
            ' map
            ' 
            Me.map.Dock = System.Windows.Forms.DockStyle.Fill
            Me.map.Layers.Add(Me.imageTilesLayer1)
            Me.map.Layers.Add(Me.vectorItemsLayer1)
            Me.map.Location = New System.Drawing.Point(0, 0)
            Me.map.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.map.Name = "map"
            Me.map.Size = New System.Drawing.Size(1462, 900)
            Me.map.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(12F, 25F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1462, 900)
            Me.Controls.Add(Me.map)
            Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.map), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private map As DevExpress.XtraMap.MapControl

        Private imageTilesLayer1 As DevExpress.XtraMap.ImageLayer

        Private openStreetMapDataProvider1 As DevExpress.XtraMap.OpenStreetMapDataProvider

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private mapItemStorage1 As DevExpress.XtraMap.MapItemStorage
    End Class
End Namespace
