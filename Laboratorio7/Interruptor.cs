using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    internal class Interruptor : IEstadoBinario //Criação de classe binaria com implementação da interface IEstadoBinario
    {
        private bool ligado;

        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            ligado = false;
        }
                
        public EstadoBinario Estado //informante para o Program
        {
            get
            {
                if (ligado)
                    return EstadoBinario.Ligado;
                else
                    return EstadoBinario.Desligado;
            }
        }


    }
}
