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

        public PositionView( IMainPresenter mainPresenter )
        {
            InitializeComponent( );
            _positionPresenter = new PositionPresenter( this, mainPresenter );
            btnLearn.Click += btnLearn_Click;
            btnGoSetupView.Click += btnGoSetupView_Click;
        }

        private void btnGoSetupView_Click( object sender, System.EventArgs e )
        {
            _positionPresenter.goSetupView( );
        }

        private void btnLearn_Click( object sender, System.EventArgs e )
        {
            _positionPresenter.learn( );
        }
    }
}