namespace AcademiaFacil.Models.View;

public class ErrorModel
{
    public ErrorModel(int statusCode, string mensagem, string imagem, string controladorDoErro, string textoBotaoControladorDoErrro, string acaoErro, string controladorVoltar, string acaoVoltar)
    {
        StatusCode = statusCode;
        Mensagem = mensagem;
        Imagem = imagem;
        ControladorDoErro = controladorDoErro;
        TextoBotaoControladorDoErrro = textoBotaoControladorDoErrro;
        AcaoErro = acaoErro;
        ControladorVoltar = controladorVoltar;
        AcaoVoltar = acaoVoltar;
    }

    public int StatusCode { get; set; }
    public string Mensagem { get; set; }
    public string Imagem { get; set; }
    public string ControladorDoErro { get; set; }
    public string TextoBotaoControladorDoErrro { get; set; }
    public string AcaoErro { get; set; }
    public string ControladorVoltar { get; set; }
    public string AcaoVoltar { get; set; }
}