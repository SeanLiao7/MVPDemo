﻿using System;
using System.Threading.Tasks;
using MetroFramework.Controls;
using MVPDemo.Presenters;

namespace MVPDemo.Views
{
    public partial class SetupView : MetroUserControl, ISetupView
    {
        private readonly ISetupPresenter _setupPresenter;

        public bool IsEnable
        {
            get => this.getUiProperty( x => x.Enabled );
            set => this.updateUi( x => x.Enabled = value );
        }

        public string Result
        {
            get => txtCounter.getUiProperty( x => x.Text );
            set => txtCounter.updateUi( x => x.Text = value );
        }

        public SetupView( ISetupPresenter setupPresenter )
        {
            InitializeComponent( );
            setupPresenter.SetupView = this;
            _setupPresenter = setupPresenter;
            btnGoPositionView.Click += btnGoPosition_Click;
            btnAddCounter.Click += btnAddCounter_Click;
            btnGoOperationView.Click += btnGoOperationView_Click;
            btnExit.Click += btnExit_Click;
        }

        public Task reloadViewContent( )
        {
            return _setupPresenter.reloadContent( );
        }

        private void btnAddCounter_Click( object sender, EventArgs e )
        {
            _setupPresenter.addCounter( );
        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            _setupPresenter.exit( );
        }

        private void btnGoOperationView_Click( object sender, EventArgs e )
        {
            _setupPresenter.goOperationView( );
        }

        private void btnGoPosition_Click( object sender, EventArgs e )
        {
            _setupPresenter.goPositionView( );
        }
    }
}