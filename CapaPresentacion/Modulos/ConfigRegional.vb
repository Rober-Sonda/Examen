Module ConfigRegional
    Public Sub ConfigLocalRegional()
        Application.EnableVisualStyles()
        ' Clonamos la información de referencia cultural del subproceso actual. 
        Config = DirectCast(Application.CurrentCulture.Clone, Globalization.CultureInfo)
        Config.NumberFormat.NumberGroupSeparator = ","
        Config.NumberFormat.CurrencyGroupSeparator = ","
        Config.NumberFormat.NumberDecimalSeparator = "."
        Config.NumberFormat.CurrencyDecimalSeparator = "."
        Config.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        Application.CurrentCulture = Config
    End Sub
End Module
