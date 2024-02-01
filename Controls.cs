using System;

public class ControlsExtension
{
    public static class ControlsExtension
    {
        public static void FindNameForFocus(this Grid pane, string propertyName)
        {
            var campoFocus = (Control)pane.FindName(propertyName);
            campoFocus.FocusForce();
        }

        public static void FindNameForFocus(this DockPanel pane, string propertyName)
        {
            var campoFocus = (Control)pane.FindName(propertyName);
            campoFocus.FocusForce();
        }

        public static void FindNameForFocus(this StackPanel pane, string propertyName)
        {
            var campoFocus = (Control)pane.FindName(propertyName);
            campoFocus.FocusForce();
        }

        public static async void FocusForce(this Control controle)
        {

            await Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Render,
                new Action(() =>
                {
                    if (controle == null) return;
                    if (controle is TextBox) ((TextBox)controle).SelectAll();
                    if (controle is SingleSearch)
                        ((SingleSearch)controle).Focus();
                    else

                        controle.Focus();
                }));
        }

        public static void MoverProximo(this KeyEventArgs e)
        {
            var requisicao = new TraversalRequest(FocusNavigationDirection.Next);
            var controle = Keyboard.FocusedElement as UIElement;
            if (controle != null && controle.MoveFocus(requisicao))
            {
                try
                {
                    var focused = FocusManager.GetFocusedElement(Window.GetWindow(controle));
                    ((Control)focused).FocusForce();

                }
                catch { }
                finally
                {
                    e.Handled = true;
                }
            }
        }
    }
}
