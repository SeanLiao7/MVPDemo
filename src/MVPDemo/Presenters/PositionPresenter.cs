﻿using System;
using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public class PositionPresenter : IPositionPresenter
    {
        private readonly IMainPresenter _mainPresenter;

        public IPositionView PositionView { get; set; }

        public PositionPresenter( IMainPresenter mainPresenter )
        {
            _mainPresenter = mainPresenter;
        }

        public void goSetupView( )
        {
            _mainPresenter.changeSubView( ViewType.Setup );
        }

        public void learn( )
        {
            var rnd = new Random( );
            var result = rnd.Next( 2 ) > 0;
            PositionView.LearnResult = result.ToString( );
        }

        public void reloadContent( )
        {
            PositionView.LearnResult = "";
        }
    }
}