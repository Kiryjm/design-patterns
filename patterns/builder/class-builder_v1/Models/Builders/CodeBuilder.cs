using System;
public class CodeBuilder
{
    protected ClassEntity _classEntity;

    public CodeBuilder(string className)
    {
        _classEntity = new ClassEntity(className);
    }

    public CodeBuilder AddField(string field, string type)
    {
        _classEntity.Types.Add(new Tuple<string, string>(field, type));
        return this;
    }

    public override string ToString()
    {
        if (_classEntity.Types.Count == 0)
        {
            return $"public class {_classEntity._className}\n{{\n}}";
        }

        var fields = string.Join("\n  ", _classEntity.Types.Select(t => $"public {t.Item2} {t.Item1};"));
        return $"public class {_classEntity._className}\n{{\n  {fields}\n}}";
    }
}