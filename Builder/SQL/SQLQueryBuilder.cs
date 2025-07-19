using System.Text;
using System.Text.RegularExpressions;

namespace Builder.SQL;

public class SQLQueryBuilder
{
    private string _select;
    private string _from;
    private string _where;
    private string _orderBy;

    public SQLQueryBuilder Select(string select)
    {
        if (string.IsNullOrWhiteSpace(select))
        {
            throw new ArgumentNullException(nameof(select));
        }

        var words = select.Split(',');
        foreach (var word in words)
        {
            if (word.Trim().Contains(' '))
            {
                throw new ArgumentException("Invalid select.");
            }
        }
        
        _select = select;
        return this;
    }

    public SQLQueryBuilder From(string from)
    {
        if (string.IsNullOrWhiteSpace(from))
        {
            throw new ArgumentNullException(nameof(from));
        }
        
        if (from.Trim().Contains(' '))
        {
            throw new ArgumentException("Invalid from.");
        }
        
        _from = from;
        return this;
    }

    public SQLQueryBuilder Where(string where)
    {
        if (string.IsNullOrWhiteSpace(where))
        {
            return this;
        }
        var result = Regex.IsMatch(where, @"^[a-zA-Z0-9]+ *(=|>|<|<>|!=|>=|<=) *'?[a-zA-Z0-9]+'?");

        if (!result)
        {
            throw new ArgumentException("Invalid where.");
        }
        _where = where;
        return this;
    }

    public SQLQueryBuilder OrderBy(string orderBy)
    {
        if (string.IsNullOrWhiteSpace(orderBy))
        {
            return this;
        }

        if (orderBy.Trim().Contains(' '))
        {
            throw new ArgumentException("Invalid orderBy.");
        }
        _orderBy = orderBy;
        return this;
    }

    public string Build()
    {
        var result = new StringBuilder();
        
        result.Append($"SELECT {_select} FROM {_from} ");
        if (!string.IsNullOrWhiteSpace(_where))
        {
            result.Append($"WHERE {_where} ");
        }

        if (!string.IsNullOrWhiteSpace(_orderBy))
        {
            result.Append($"ORDER BY {_orderBy} ");
        }
        return result.ToString();
    }
}