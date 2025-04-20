using OpenAI.Chat;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        ChatClient client = new(model: "gpt-4o-mini", apiKey: "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");

        ChatCompletion completion = client.CompleteChat($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal.");
        banda.Resumo = completion.Content[0].Text; //Console.WriteLine($"{completion.Content[0].Text}");

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
