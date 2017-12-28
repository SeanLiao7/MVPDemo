using System;
using System.Windows.Forms;

namespace MVPDemo
{
    public static class Extensions
    {
        public static TResult getUiProperty<TIn, TResult>( this TIn control, Func<TIn, TResult> func )
            where TIn : Control
        {
            if ( control.InvokeRequired )
                return ( TResult ) control.Invoke( new Func<TIn, TResult>( x => x.getUiProperty( func ) ), control );
            return func( control );
        }

        public static void updateUi<TIn>( this TIn control, Action<TIn> action )
            where TIn : Control
        {
            if ( control.InvokeRequired )
                control.Invoke( new Action<TIn>( x => x.updateUi( action ) ), control );
            else
                action( control );
        }
    }
}