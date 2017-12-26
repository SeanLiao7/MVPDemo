using System;
using MetroFramework.Controls;
using MVPDemo.Presenters;

namespace MVPDemo.Views
{
    public partial class PositionView : MetroUserControl, IPositionView
    {
        private readonly IPositionPresenter _positionPresenter;

        public string LearnResult
        {
            get => txtResult.Text;
            set => txtResult.Text = value;
        }

        public PositionView( IPositionPresenter positionPresenter )
        {
            InitializeComponent( );
            positionPresenter.PositionView = this;
            _positionPresenter = positionPresenter;
            btnLearn.Click += btnLearn_Click;
            btnGoSetupView.Click += btnGoSetupView_Click;
        }

        public void reloadViewContent( )
        {
            _positionPresenter.reloadContent( );
        }

        private void btnGoSetupView_Click( object sender, EventArgs e )
        {
            _positionPresenter.goSetupView( );
        }

        private void btnLearn_Click( object sender, EventArgs e )
        {
            _positionPresenter.learn( );
        }
    }
}