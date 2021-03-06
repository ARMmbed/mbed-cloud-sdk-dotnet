using Manhasset.Core.src.Containers;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Manhasset.Generator.src.CustomContainers
{
    public class DeferedMethodCallReturnStatementContainer : ReturnStatementContainer
    {
        public string MethodName { get; set; }
        public string DeferedEntity { get; set; }
        public override StatementSyntax GetSyntax()
        {
            return SyntaxFactory.ReturnStatement(
                SyntaxFactory.AwaitExpression(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.IdentifierName(DeferedEntity),
                            SyntaxFactory.IdentifierName(MethodName)))));
        }
    }
}