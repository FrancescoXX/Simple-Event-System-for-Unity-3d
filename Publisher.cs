//SRP: Expose Delegate Pattern Globally with Singleton instance (i)
public class Publisher {

  //Event Handlers Params
  public delegate void EventHandler();

  //Event Definition
  public event EventHandler StartGame;

  
  public void CallStartGame() => StartGame?.Invoke();

  //Singleton
  private static Publisher instance;
  protected Publisher() { }

  public static Publisher i {
    get {
      if (instance == null)instance = new Publisher();
      return instance;
    }
  }
}