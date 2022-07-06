using System;
using UnityEngine;
/*
 * View Manager to agency all UI views
 */
namespace Eyes4Eye.UI
{
    public sealed class ViewManager: MonoBehaviour
    {
        public static ViewManager Instance { get; private set; }

        [Header("View refs to be managed")]
        [SerializeField]
        private View[] views;

        [Header("Default view to be shown")]
        [SerializeField] 
        private View defaultView;

        private View _currentView;

        [Header("If View manager should initialize automatically")]
        [SerializeField]
        private bool autoInitialize;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            if(autoInitialize) Initialize();
        }

        //Initialize all views
        public void Initialize()
        {
            foreach (View view in views)
            {
                view.Initialize();
                view.Hide();
            }
            if(defaultView !=null) 
                Show(defaultView);
        }
        
        //Show a valid View and set as current
        public void Show<TView>(object args = null) where TView : View
        {
            foreach (View view in views)
            {
                if (view is not TView) continue;
                if(_currentView != null) _currentView.Hide();
                view.Show();
                _currentView = view;
                break;
            }
        }

        //Show Generic view
        public void Show(View view, object args = null)
        {
            if(_currentView != null) _currentView.Hide();
            view.Show();
            _currentView = view;
        }
        
        
    }
}