namespace AcademiaFacil.Models.View;

public class ErrorModel
{
    public ErrorModel(string statusCode, string mensagem, string imagem)
    {
        StatusCode = statusCode;
        Mensagem = mensagem;
        Imagem = imagem;
    }

    public string StatusCode { get; set; }
    public string Mensagem { get; set; }

    public string Imagem { get; set; }
}