<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpzioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsciSenzaSalvareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancellaTuttoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardaIlTutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormattazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorsivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DimensioneCarattereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 31)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(801, 427)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Type here"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(694, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SALVAA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(523, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "OPEN A FAIL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Auto blu bella"
        Me.SaveFileDialog1.Filter = "File di testo|*.txt |AUTO BLU |*.autoblu"
        Me.SaveFileDialog1.InitialDirectory = "C:\"
        Me.SaveFileDialog1.Title = "Salva nabbo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "File di testo|*.txt |AUTO BLU |*.autoblu"
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.Title = "SI APRI LAMO"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OpzioniToolStripMenuItem, Me.TutorialToolStripMenuItem, Me.InformazioniToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalvaToolStripMenuItem, Me.EsciSenzaSalvareToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpzioniToolStripMenuItem
        '
        Me.OpzioniToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancellaTuttoToolStripMenuItem, Me.FormattazioneToolStripMenuItem})
        Me.OpzioniToolStripMenuItem.Name = "OpzioniToolStripMenuItem"
        Me.OpzioniToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.OpzioniToolStripMenuItem.Text = "Opzioni"
        '
        'TutorialToolStripMenuItem
        '
        Me.TutorialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardaIlTutorialToolStripMenuItem})
        Me.TutorialToolStripMenuItem.Name = "TutorialToolStripMenuItem"
        Me.TutorialToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.TutorialToolStripMenuItem.Text = "Tutorial"
        '
        'InformazioniToolStripMenuItem
        '
        Me.InformazioniToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.LicenseToolStripMenuItem})
        Me.InformazioniToolStripMenuItem.Name = "InformazioniToolStripMenuItem"
        Me.InformazioniToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.InformazioniToolStripMenuItem.Text = "Informazioni"
        '
        'SalvaToolStripMenuItem
        '
        Me.SalvaToolStripMenuItem.Name = "SalvaToolStripMenuItem"
        Me.SalvaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SalvaToolStripMenuItem.Text = "Salva"
        '
        'EsciSenzaSalvareToolStripMenuItem
        '
        Me.EsciSenzaSalvareToolStripMenuItem.Name = "EsciSenzaSalvareToolStripMenuItem"
        Me.EsciSenzaSalvareToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EsciSenzaSalvareToolStripMenuItem.Text = "Esci senza salvare"
        '
        'CancellaTuttoToolStripMenuItem
        '
        Me.CancellaTuttoToolStripMenuItem.Name = "CancellaTuttoToolStripMenuItem"
        Me.CancellaTuttoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CancellaTuttoToolStripMenuItem.Text = "Cancella tutto"
        '
        'GuardaIlTutorialToolStripMenuItem
        '
        Me.GuardaIlTutorialToolStripMenuItem.Name = "GuardaIlTutorialToolStripMenuItem"
        Me.GuardaIlTutorialToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.GuardaIlTutorialToolStripMenuItem.Text = "Guarda il tutorial..."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'FormattazioneToolStripMenuItem
        '
        Me.FormattazioneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorsivoToolStripMenuItem, Me.DimensioneCarattereToolStripMenuItem})
        Me.FormattazioneToolStripMenuItem.Name = "FormattazioneToolStripMenuItem"
        Me.FormattazioneToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FormattazioneToolStripMenuItem.Text = "Formattazione"
        '
        'CorsivoToolStripMenuItem
        '
        Me.CorsivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9})
        Me.CorsivoToolStripMenuItem.Name = "CorsivoToolStripMenuItem"
        Me.CorsivoToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.CorsivoToolStripMenuItem.Text = "Dimensione carattere"
        '
        'DimensioneCarattereToolStripMenuItem
        '
        Me.DimensioneCarattereToolStripMenuItem.Name = "DimensioneCarattereToolStripMenuItem"
        Me.DimensioneCarattereToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.DimensioneCarattereToolStripMenuItem.Text = "Apri menù formattazione"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem2.Text = "8"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem3.Text = "10"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem4.Text = "12"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem5.Text = "14"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem6.Text = "16"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem7.Text = "32"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem8.Text = "48"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem9.Text = "64"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "AUTO BLU - Open fail"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EsciSenzaSalvareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpzioniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancellaTuttoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TutorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardaIlTutorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformazioniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormattazioneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorsivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DimensioneCarattereToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
End Class
