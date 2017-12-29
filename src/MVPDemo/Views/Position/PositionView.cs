using System;
using System.Threading.Tasks;
using MetroFramework.Controls;
using MVPDemo.Presenters;

namespace MVPDemo.Views
{
    public partial class PositionView : MetroUserControl, IPositionView
    {
        private readonly IPositionPresenter _positionPresenter;

        public bool IsEnable
        {
            get => this.getUiProperty( x => x.Enabled );
            set => this.updateUi( x => x.Enabled = value );
        }

        public string LearnResult
        {
            get => txtResult.getUiProperty( x => x.Text );
            set => txtResult.updateUi( x => x.Text = value );
        }

        public PositionView( IPositionPresenter positionPresenter )
        {
            InitializeComponent( );
            positionPresenter.PositionView = this;
            _positionPresenter = positionPresenter;
            btnLearn.Click += btnLearn_Click;
            btnGoSetupView.Click += btnGoSetupView_Click;
        }

        public Task reloadViewContent( )
        {
            return _positionPresenter.reloadContent( );
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