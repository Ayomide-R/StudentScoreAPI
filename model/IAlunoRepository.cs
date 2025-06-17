namespace StudentScoreAPI.model
{
    public interface IAlunoRepository
    {
        void Aluno (Aluno aluno);

        List<Aluno> Get();
    }
}
