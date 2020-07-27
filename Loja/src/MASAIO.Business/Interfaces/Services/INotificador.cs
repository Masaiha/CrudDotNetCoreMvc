using MASAIO.Business.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace MASAIO.Business.Interfaces.Services
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacao();
        void Handle(Notificacao notificacao);
    }
}
