using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeEx
{
  public class WindowImpl : Window
  {
    public WindowImpl()
    {
      scrollbar = new HorizontalScrollbar();
      //..
    }

    public void Draw()
    {
      scrollbar.Draw();
    }

    private Scrollbar scrollbar;
  }
}