using System;
using System.Windows.Forms;

namespace MVPDemo
{
    public static class Extensions
    {
        public static T getUiProperty<T>( this Control control, Func<T> func )
        {
            if ( control.InvokeRequired )
                return ( T ) control.Invoke( new Func<T>( ( ) => control.getUiProperty( func ) ) );
            return func( );
        }

        public static void updateUi( this Control control, Action action )
        {
            if ( control.InvokeRequired )
                control.Invoke( new Action( ( ) => control.updateUi( action ) ) );
            else
                action( );
        }
    }
}