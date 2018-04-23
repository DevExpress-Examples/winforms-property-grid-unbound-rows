Namespace DXApplication3
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
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.propertyDescriptionControl1 = New DevExpress.XtraVerticalGrid.PropertyDescriptionControl()
            Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            Me.sourceObject1 = New DXApplication3.SourceObject()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            DirectCast(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.splitContainerControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelControl1.Location = New System.Drawing.Point(431, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(451, 448)
            Me.panelControl1.TabIndex = 0
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(2, 2)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.propertyGridControl1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.propertyDescriptionControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(447, 444)
            Me.splitContainerControl1.SplitterPosition = 326
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' propertyDescriptionControl1
            ' 
            Me.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyDescriptionControl1.Location = New System.Drawing.Point(0, 0)
            Me.propertyDescriptionControl1.Name = "propertyDescriptionControl1"
            Me.propertyDescriptionControl1.PropertyGrid = Me.propertyGridControl1
            Me.propertyDescriptionControl1.Size = New System.Drawing.Size(447, 113)
            Me.propertyDescriptionControl1.TabIndex = 2
            Me.propertyDescriptionControl1.TabStop = False
            ' 
            ' propertyGridControl1
            ' 
            Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.propertyGridControl1.Name = "propertyGridControl1"
            Me.propertyGridControl1.SelectedObject = Me.sourceObject1
            Me.propertyGridControl1.Size = New System.Drawing.Size(447, 326)
            Me.propertyGridControl1.TabIndex = 1
            ' 
            ' sourceObject1
            ' 
            Me.sourceObject1.TestProperty = "TestValue"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(882, 448)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            DirectCast(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
        Private propertyDescriptionControl1 As DevExpress.XtraVerticalGrid.PropertyDescriptionControl
        Private sourceObject1 As SourceObject
    End Class
End Namespace

