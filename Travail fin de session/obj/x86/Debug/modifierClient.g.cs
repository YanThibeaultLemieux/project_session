﻿#pragma checksum "C:\Users\Sorde\source\repos\Travail fin de session\Travail fin de session\modifierClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "801036FB3442F3E57046CEAB3F70AD0D0CB644E7537492A93ECC1415D0B28587"
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
    partial class modifierClient : 
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
            case 2: // modifierClient.xaml line 34
                {
                    this.nomClient = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // modifierClient.xaml line 35
                {
                    this.erreurNom = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // modifierClient.xaml line 38
                {
                    this.telClient = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // modifierClient.xaml line 40
                {
                    this.erreurTelephone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // modifierClient.xaml line 44
                {
                    this.posteClient = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // modifierClient.xaml line 48
                {
                    this.bureauClient = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // modifierClient.xaml line 51
                {
                    this.typeClient = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 9: // modifierClient.xaml line 55
                {
                    this.emailClient = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // modifierClient.xaml line 56
                {
                    this.ErreurEmail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // modifierClient.xaml line 60
                {
                    this.prenomClient = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // modifierClient.xaml line 61
                {
                    this.ErreurPrenom = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // modifierClient.xaml line 69
                {
                    this.Envoyer = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Envoyer).Click += this.EnvoyerClient;
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

