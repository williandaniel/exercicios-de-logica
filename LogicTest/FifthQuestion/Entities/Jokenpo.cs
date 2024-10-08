using System;
using FifthQuestion.Entities.Enums;
using FifthQuestion.Entities.Exceptions;

namespace FifthQuestion.Entities
{
    class Jokenpo
    {
        public JokenpoOption UserOption { get; set; }
        private ComputerMove computerMove;
        public JokenpoOption ComputerOption { get; private set; }


        public Jokenpo(JokenpoOption userOption)
        {
            if (!Enum.IsDefined(typeof(JokenpoOption), userOption))
            {
                throw new OptionException("Opção inválida. Escolha entre as opções: 1 - Pedra, 2 - Papel, 3 - Tesoura.");
            }

            UserOption = userOption;
            computerMove = new ComputerMove();
            ComputerOption = computerMove.GetComputerMove();
        }

        private string Winner()
        {
            if (UserOption == ComputerOption)
            {
                return "Empate";
            }
            if (UserOption == JokenpoOption.Papel && ComputerOption == JokenpoOption.Pedra
                || UserOption == JokenpoOption.Pedra && ComputerOption == JokenpoOption.Tesoura
                || UserOption == JokenpoOption.Tesoura && ComputerOption == JokenpoOption.Papel)
            {
                return "Jogador";
            }
            else
            {
                return "Computador";
            }
        }

        public override string ToString()
        {
            return "Você Jogador escolheu: ["
                + UserOption
                + "] e o Computador escolheu: ["
                + ComputerOption
                + "]. O vencedor entre os dois é: "
                + Winner();
        }

    }
}
