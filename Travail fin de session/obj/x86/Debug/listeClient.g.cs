﻿#pragma checksum "C:\Users\Sorde\Source\Repos\YanThibeaultLemieux\project_session\Travail fin de session\listeClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F9240A0DB108BB0B5F38CF56B8299971F186DB31957764B4E1D9A7D27688FB69"
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
    partial class listeClient : 
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
            case 2: // listeClient.xaml line 36
                {
                    this.btAjouter = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btAjouter).Click += this.Ajouter_Click;
                }
                break;
            case 3: // listeClient.xaml line 37
                {
                    this.btModifier = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btModifier).Click += this.Modifier_Click;
                }
                break;
            case 4: // listeClient.xaml line 38
                {
                    this.erreurPick = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // listeClient.xaml line 42
                {
                    this.Rechercher_Entry = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // listeClient.xaml line 43
                {
                    this.Rechercher_Bouton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Rechercher_Bouton).Click += this.Rechercher_Bouton_Click;
                }
                break;
            case 7: // listeClient.xaml line 44
                {
                    this.résultat = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // listeClient.xaml line 15
                {
                    this.grilleNom = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
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

