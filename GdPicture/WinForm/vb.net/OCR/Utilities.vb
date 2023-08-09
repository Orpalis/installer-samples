Imports GdPicture14

Namespace Ocr

    Class Utilities

        Public Shared Sub MarkRegions(ByVal gdViewer As GdViewer, ByVal blocks As Rectangle(), ByVal paragraphs As Rectangle(), ByVal textLines As Rectangle(), ByVal words As Rectangle(), ByVal characters As Rectangle(), ByVal horizontalResolution As Single, ByVal verticalResolution As Single)
            gdViewer.RemoveAllRegions()
            If blocks IsNot Nothing Then
                AddRegions(gdViewer, blocks, BlockColor, horizontalResolution, verticalResolution)
            End If

            If paragraphs IsNot Nothing Then
                AddRegions(gdViewer, paragraphs, ParagraphColor, horizontalResolution, verticalResolution)
            End If

            If textLines IsNot Nothing Then
                AddRegions(gdViewer, textLines, TextLineColor, horizontalResolution, verticalResolution)
            End If

            If words IsNot Nothing Then
                AddRegions(gdViewer, words, WordColor, horizontalResolution, verticalResolution)
            End If

            If characters IsNot Nothing Then
                AddRegions(gdViewer, characters, CharacterColor, horizontalResolution, verticalResolution)
            End If
        End Sub

        Public Shared Function GetBlocksBoundingBoxes(ByVal ocrResultId As String, ByVal gdPictureOcr As GdPictureOCR) As Rectangle()
            Dim rectanglesList As List(Of Rectangle) = New List(Of Rectangle)()
            Dim blocksCount As Integer = gdPictureOcr.GetBlockCount(ocrResultId)
            For blockIndex As Integer = 0 To blocksCount - 1
                rectanglesList.Add(New Rectangle(gdPictureOcr.GetBlockLeft(ocrResultId, blockIndex), gdPictureOcr.GetBlockTop(ocrResultId, blockIndex), gdPictureOcr.GetBlockRight(ocrResultId, blockIndex) - gdPictureOcr.GetBlockLeft(ocrResultId, blockIndex), gdPictureOcr.GetBlockBottom(ocrResultId, blockIndex) - gdPictureOcr.GetBlockTop(ocrResultId, blockIndex)))
            Next

            Return rectanglesList.ToArray()
        End Function

        Public Shared Function GetParagraphsBoundingBoxes(ByVal ocrResultId As String, ByVal gdPictureOcr As GdPictureOCR) As Rectangle()
            Dim rectanglesList As List(Of Rectangle) = New List(Of Rectangle)()
            Dim paragraphCount As Integer = gdPictureOcr.GetParagraphCount(ocrResultId)
            For paragraphsIndex As Integer = 0 To paragraphCount - 1
                rectanglesList.Add(New Rectangle(gdPictureOcr.GetParagraphLeft(ocrResultId, paragraphsIndex), gdPictureOcr.GetParagraphTop(ocrResultId, paragraphsIndex), gdPictureOcr.GetParagraphRight(ocrResultId, paragraphsIndex) - gdPictureOcr.GetParagraphLeft(ocrResultId, paragraphsIndex), gdPictureOcr.GetParagraphBottom(ocrResultId, paragraphsIndex) - gdPictureOcr.GetParagraphTop(ocrResultId, paragraphsIndex)))
            Next

            Return rectanglesList.ToArray()
        End Function

        Public Shared Function GetTextLinesBoundingBoxes(ByVal ocrResultId As String, ByVal gdPictureOcr As GdPictureOCR) As Rectangle()
            Dim rectanglesList As List(Of Rectangle) = New List(Of Rectangle)()
            Dim textLineCount As Integer = gdPictureOcr.GetTextLineCount(ocrResultId)
            For textLinesIndex As Integer = 0 To textLineCount - 1
                rectanglesList.Add(New Rectangle(gdPictureOcr.GetTextLineLeft(ocrResultId, textLinesIndex), gdPictureOcr.GetTextLineTop(ocrResultId, textLinesIndex), gdPictureOcr.GetTextLineRight(ocrResultId, textLinesIndex) - gdPictureOcr.GetTextLineLeft(ocrResultId, textLinesIndex), gdPictureOcr.GetTextLineBottom(ocrResultId, textLinesIndex) - gdPictureOcr.GetTextLineTop(ocrResultId, textLinesIndex)))
            Next

            Return rectanglesList.ToArray()
        End Function

        Public Shared Function GetWordsBoundingBoxes(ByVal ocrResultId As String, ByVal gdPictureOcr As GdPictureOCR) As Rectangle()
            Dim rectanglesList As List(Of Rectangle) = New List(Of Rectangle)()
            Dim wordCount As Integer = gdPictureOcr.GetWordCount(ocrResultId)
            For wordIndex As Integer = 0 To wordCount - 1
                rectanglesList.Add(New Rectangle(gdPictureOcr.GetWordLeft(ocrResultId, wordIndex), gdPictureOcr.GetWordTop(ocrResultId, wordIndex), gdPictureOcr.GetWordRight(ocrResultId, wordIndex) - gdPictureOcr.GetWordLeft(ocrResultId, wordIndex), gdPictureOcr.GetWordBottom(ocrResultId, wordIndex) - gdPictureOcr.GetWordTop(ocrResultId, wordIndex)))
            Next

            Return rectanglesList.ToArray()
        End Function

        Public Shared Function GetCharactersBoundingBoxes(ByVal ocrResultId As String, ByVal gdPictureOcr As GdPictureOCR) As Rectangle()
            Dim rectanglesList As List(Of Rectangle) = New List(Of Rectangle)()
            Dim blocksCount As Integer = gdPictureOcr.GetBlockCount(ocrResultId)
            Dim paragaphIndexGlobal As Integer = 0
            Dim textLineIndexGlobal As Integer = 0
            Dim wordIndexGlobal As Integer = 0
            Dim characterIndexGlobal As Integer = 0
            For blockIndex As Integer = 0 To blocksCount - 1
                Dim paragaphsCount As Integer = gdPictureOcr.GetBlockParagraphCount(ocrResultId, blockIndex)
                For paragaphIndex As Integer = 0 To paragaphsCount - 1
                    Dim textLinesCount As Integer = gdPictureOcr.GetParagraphTextLineCount(ocrResultId, paragaphIndexGlobal)
                    For textLineIndex As Integer = 0 To textLinesCount - 1
                        Dim wordsCount As Integer = gdPictureOcr.GetTextLineWordCount(ocrResultId, textLineIndexGlobal)
                        For wordIndex As Integer = 0 To wordsCount - 1
                            Dim charactersCount As Integer = gdPictureOcr.GetWordCharacterCount(ocrResultId, wordIndexGlobal)
                            For characterIndex As Integer = 0 To charactersCount - 1
                                rectanglesList.Add(New Rectangle(gdPictureOcr.GetCharacterLeft(ocrResultId, characterIndexGlobal), gdPictureOcr.GetCharacterTop(ocrResultId, characterIndexGlobal), gdPictureOcr.GetCharacterRight(ocrResultId, characterIndexGlobal) - gdPictureOcr.GetCharacterLeft(ocrResultId, characterIndexGlobal), gdPictureOcr.GetCharacterBottom(ocrResultId, characterIndexGlobal) - gdPictureOcr.GetCharacterTop(ocrResultId, characterIndexGlobal)))
                                characterIndexGlobal += 1
                            Next

                            wordIndexGlobal += 1
                        Next

                        textLineIndexGlobal += 1
                    Next

                    paragaphIndexGlobal += 1
                Next
            Next

            Return rectanglesList.ToArray()
        End Function

        Public Shared Function GetCharactersBoundingBoxesSimplified(ByVal ocrResultId As String, ByVal gdPictureOcr As GdPictureOCR) As Rectangle()
            Dim rectanglesList As List(Of Rectangle) = New List(Of Rectangle)()
            Dim characterCount As Integer = gdPictureOcr.GetCharacterCount(ocrResultId)
            For characterIndex As Integer = 0 To characterCount - 1
                If gdPictureOcr.GetCharacterValue(ocrResultId, characterIndex) <> "~"c Then
                    rectanglesList.Add(New Rectangle(gdPictureOcr.GetCharacterLeft(ocrResultId, characterIndex), gdPictureOcr.GetCharacterTop(ocrResultId, characterIndex), gdPictureOcr.GetCharacterRight(ocrResultId, characterIndex) - gdPictureOcr.GetCharacterLeft(ocrResultId, characterIndex), gdPictureOcr.GetCharacterBottom(ocrResultId, characterIndex) - gdPictureOcr.GetCharacterTop(ocrResultId, characterIndex)))
                End If
            Next

            Return rectanglesList.ToArray()
        End Function

        Private Shared Sub AddRegions(ByVal gdViewer As GdViewer, ByVal rectangles As Rectangle(), ByVal color As Color, ByVal horizontalResolution As Single, ByVal verticalResolution As Single)
            For Each rectangle In rectangles
                Dim regionId As Integer = gdViewer.AddRegionInches("", rectangle.Left / horizontalResolution, rectangle.Top / verticalResolution, (rectangle.Right - rectangle.Left) / horizontalResolution, (rectangle.Bottom - rectangle.Top) / verticalResolution, ForegroundMixMode.ForegroundMixModeUNDEFINED, color)
                gdViewer.SetRegionEditable(regionId, False)
                gdViewer.SetRegionBorderWidth(regionId, 1)
                gdViewer.SetRegionBorderColor(regionId, color)
            Next
        End Sub

        Private Shared ReadOnly BlockColor As Color = Color.Green

        Private Shared ReadOnly ParagraphColor As Color = Color.Cyan

        Private Shared ReadOnly TextLineColor As Color = Color.Magenta

        Private Shared ReadOnly WordColor As Color = Color.Blue

        Private Shared ReadOnly CharacterColor As Color = Color.Red
    End Class
End Namespace