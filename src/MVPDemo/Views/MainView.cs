﻿using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MVPDemo.Presenters;

namespace MVPDemo.Views
{
    public partial class MainView : MetroForm, IMainView
    {
        private readonly IMainPresenter _mainPresenter;

        public ISubView SubView
        {
            get => MainPanel.Controls.Count > 0
                ? MainPanel.Controls[ 0 ] is ISubView view
                    ? view
                    : throw new InvalidCastException( $"Can't find relevant view, property name :{nameof( SubView )}" )
                : default( ISubView );
            set
            {
                MainPanel.Controls.Clear( );
                if ( value is UserControl control )
                    MainPanel.Controls.Add( control );
                else
                    throw new InvalidCastException( $"Can't find relevant view, input name :{nameof( value )}" );
            }
        }

        public MainView( )
        {
            InitializeComponent( );
            _mainPresenter = new MainPresenter( this );
        }

        protected override void OnLoad( EventArgs e )
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            base.OnLoad( e );
        }
    }
}