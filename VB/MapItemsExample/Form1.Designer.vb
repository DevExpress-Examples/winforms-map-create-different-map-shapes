Namespace WindowsFormsApplication3
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim imageTilesLayer1 As New DevExpress.XtraMap.ImageTilesLayer()
            Dim openStreetMapDataProvider1 As New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Dim vectorItemsLayer1 As New DevExpress.XtraMap.VectorItemsLayer()
            Dim keyColorColorizer1 As New DevExpress.XtraMap.KeyColorColorizer()
            Dim argumentItemKeyProvider1 As New DevExpress.XtraMap.ArgumentItemKeyProvider()
            Dim mapItemStorage1 As New DevExpress.XtraMap.MapItemStorage()
            Me.map = New DevExpress.XtraMap.MapControl()
            DirectCast(Me.map, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' map
            ' 
            Me.map.Dock = System.Windows.Forms.DockStyle.Fill
            imageTilesLayer1.DataProvider = openStreetMapDataProvider1
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette
            vectorItemsLayer1.Colorizer = keyColorColorizer1
            vectorItemsLayer1.Data = mapItemStorage1
            vectorItemsLayer1.Name = "VectorLayer"
            Me.map.Layers.Add(imageTilesLayer1)
            Me.map.Layers.Add(vectorItemsLayer1)
            Me.map.Location = New System.Drawing.Point(0, 0)
            Me.map.Name = "map"
            Me.map.Size = New System.Drawing.Size(731, 468)
            Me.map.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(731, 468)
            Me.Controls.Add(Me.map)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.map, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private map As DevExpress.XtraMap.MapControl

    End Class
End Namespace

