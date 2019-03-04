﻿Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxScheduler

Partial Public Class UserForms_AppointmentDragToolTip
	Inherits ASPxSchedulerToolTipBase

	Public Overrides ReadOnly Property ClassName() As String
		Get
			Return "ASPxClientAppointmentDragTooltip"
		End Get
	End Property
	Public Overrides ReadOnly Property ToolTipShowStem() As Boolean
		Get
			Return True
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		DevExpress.Web.ASPxWebControl.RegisterBaseScript(Page)
	End Sub
	Protected Overrides Function GetChildControls() As Control()
'INSTANT VB NOTE: The variable controls was renamed since Visual Basic does not handle local variables named the same as class members well:
		Dim controls_Renamed() As Control = { lblInterval }
		Return controls_Renamed
	End Function
End Class
