﻿#pragma checksum "C:\Users\Sorde\source\repos\Travail fin de session\Travail fin de session\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FDA924EF65F97715B17C71DBEC4193A8501B20AEA045E3D80C86EBA029940D00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travail_fin_de_session
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 33
                {
                    this.nomUtilisateur = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // MainPage.xaml line 36
                {
                    this.motdepasse = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // MainPage.xaml line 38
                {
                    this.btLogin = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btLogin).Click += this.btLogin_Click;
                }
                break;
            case 5: // MainPage.xaml line 41
                {
                    this.ERREURLOGIN = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

