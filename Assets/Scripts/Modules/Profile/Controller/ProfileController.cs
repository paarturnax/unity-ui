using System;
using System.Diagnostics;
using Data;
using Modules.Profile.Model;
using Modules.Profile.View;
using Zenject;

namespace Modules.Profile.Controller
{
    public class ProfileController : IInitializable, IDisposable
    {
        private readonly ProfileModel m_model;
        private readonly ProfileView m_view;

        public ProfileController(ProfileModel model, ProfileView view)
        {
            m_model = model;
            m_view = view;
        }

        public void Initialize()
        {
            m_view.InitializeUI(m_model.GetAccount());
        }

        public void Dispose()
        {
            
        }
    }
}
