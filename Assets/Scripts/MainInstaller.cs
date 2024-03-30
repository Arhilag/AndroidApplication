using UnityEngine;
using Zenject;

public class MainInstaller : MonoInstaller
{
    [SerializeField] private WindowManager _windowManager;
    [SerializeField] private WindowSelector _selectorPrefab;
    [SerializeField] private ContentView[] _contents;
    
    public override void InstallBindings()
    {
        ContainerViewManager containerViewManager = new ContainerViewManager();
        
        Container.Bind<ContainerViewManager>().FromInstance(containerViewManager);
        Container.Bind<WindowManager>().FromInstance(_windowManager);
        Container.Bind<WindowSelector>().FromInstance(_selectorPrefab);
        Container.Bind<ContentView[]>().FromInstance(_contents);
    }
}