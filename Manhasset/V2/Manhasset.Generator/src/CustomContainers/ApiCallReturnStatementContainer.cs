using System.Collections.Generic;
using System.Linq;
using Manhasset.Core.src.Containers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Manhasset.Generator.src.CustomContainers
{
    public class ApiCallReturnStatementContainer : ReturnStatementContainer
    {
        public string Path { get; set; }
        public List<MyParameterContainer> PathParams { get; set; }
        public List<MyParameterContainer> QueryParams { get; set; }
        public List<MyParameterContainer> FileParams { get; set; }
        public List<MyParameterContainer> BodyParams { get; set; }
        public string HttpMethod { get; set; }

        public override ReturnStatementSyntax GetSyntax()
        {
            var paramArgList = new List<SyntaxNodeOrToken>();

            paramArgList.Add(GetLiteralArg("path", Path));
            paramArgList.Add(SyntaxFactory.Token(SyntaxKind.CommaToken));

            if (PathParams.Any())
            {
                paramArgList.Add(GetVariableArg("pathParams", "pathParams"));
                paramArgList.Add(SyntaxFactory.Token(SyntaxKind.CommaToken));
            }

            if (QueryParams.Any())
            {
                paramArgList.Add(GetVariableArg("queryParams", "queryParams"));
                paramArgList.Add(SyntaxFactory.Token(SyntaxKind.CommaToken));
            }

            if (FileParams.Any())
            {
                paramArgList.Add(GetVariableArg("fileParams", "fileParams"));
                paramArgList.Add(SyntaxFactory.Token(SyntaxKind.CommaToken));
            }

            if (BodyParams.Any())
            {
                paramArgList.Add(GetVariableArg("bodyParams", "bodyParams"));
                paramArgList.Add(SyntaxFactory.Token(SyntaxKind.CommaToken));
            }

            paramArgList.Add(GetMemberAccessArg("method", "HttpMethods", HttpMethod));
            paramArgList.Add(SyntaxFactory.Token(SyntaxKind.CommaToken));

            paramArgList.Add(GetThisArg("objectToUnpack"));

            return SyntaxFactory.ReturnStatement(
                SyntaxFactory.AwaitExpression(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.IdentifierName("Client"),
                            SyntaxFactory.GenericName(
                                SyntaxFactory.Identifier("CallApi"))
                            .WithTypeArgumentList(
                                SyntaxFactory.TypeArgumentList(
                                    SyntaxFactory.SingletonSeparatedList<TypeSyntax>(
                                        SyntaxFactory.IdentifierName("User"))))))
                    .WithArgumentList(
                        SyntaxFactory.ArgumentList(
                            SyntaxFactory.SeparatedList<ArgumentSyntax>(
                                paramArgList.ToArray()
                            )))));
        }
    }
}