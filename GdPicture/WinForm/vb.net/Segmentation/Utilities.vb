Imports GdPicture14

Friend Class Utilities

    Shared ReadOnly BlockColor As Color = Color.Green
    Shared ReadOnly ParagraphColor As Color = Color.Cyan
    Shared ReadOnly TextLineColor As Color = Color.Magenta
    Shared ReadOnly WordColor As Color = Color.Blue
    Shared ReadOnly CharacterColor As Color = Color.Red

    Public Shared Sub MarkRegions(ByVal gdPictureSegmenter As GdPictureSegmenter, ByVal resultID As String, ByVal gdViewer As GdViewer, ByVal showBlocks As Boolean,
                                  ByVal showParagraphs As Boolean, ByVal showTextLines As Boolean, ByVal showWords As Boolean, ByVal showCharacters As Boolean,
                                  ByVal showText As Boolean, ByVal showBitmap As Boolean, ByVal showLines As Boolean, ByVal horizontalResolution As Single, ByVal verticalResolution As Single)
        gdViewer.RemoveAllRegions()

        Dim blocks As List(Of Rectangle)
        Dim paragraphs As List(Of Rectangle)
        Dim lines As List(Of Rectangle)
        Dim words As List(Of Rectangle)
        Dim chars As List(Of Rectangle)

        GetElementsBoundingBoxes(gdPictureSegmenter, resultID, showText, showBitmap, showLines, blocks, paragraphs, lines, words, chars)
        If showBlocks Then
            AddRegions(gdViewer, blocks, BlockColor, horizontalResolution, verticalResolution)
        End If

        If showParagraphs Then
            AddRegions(gdViewer, paragraphs, ParagraphColor, horizontalResolution, verticalResolution)
        End If

        If showTextLines Then
            AddRegions(gdViewer, lines, TextLineColor, horizontalResolution, verticalResolution)
        End If

        If showWords Then
            AddRegions(gdViewer, words, WordColor, horizontalResolution, verticalResolution)
        End If

        If showCharacters Then
            AddRegions(gdViewer, chars, CharacterColor, horizontalResolution, verticalResolution)
        End If

    End Sub

    Private Shared Sub GetElementsBoundingBoxes(ByVal gdPictureSegmenter As GdPictureSegmenter, ByVal segmentationResultId As String, ByVal getText As Boolean,
                                               ByVal getBitmap As Boolean, ByVal getLines As Boolean, ByRef blocks As List(Of Rectangle), ByRef paragraphs As List(Of Rectangle),
                                               ByRef lines As List(Of Rectangle), ByRef words As List(Of Rectangle), ByRef chars As List(Of Rectangle))
        blocks = New List(Of Rectangle)
        paragraphs = New List(Of Rectangle)
        lines = New List(Of Rectangle)
        words = New List(Of Rectangle)
        chars = New List(Of Rectangle)
        Dim blocksCount As Integer = gdPictureSegmenter.GetBlockCount(segmentationResultId)
        Dim blockIndex As Integer = 0
        Do While blockIndex < blocksCount
            Dim blockType As OCRBlockType = gdPictureSegmenter.GetBlockType(segmentationResultId, blockIndex)
            If (getText AndAlso IsTextBlockType(blockType)) OrElse (getBitmap AndAlso IsImageBlockType(blockType)) OrElse (getLines AndAlso IsLineBlockType(blockType)) Then
                blocks.Add(New Rectangle(gdPictureSegmenter.GetBlockLeft(segmentationResultId, blockIndex), gdPictureSegmenter.GetBlockTop(segmentationResultId, blockIndex), gdPictureSegmenter.GetBlockRight(segmentationResultId, blockIndex) - gdPictureSegmenter.GetBlockLeft(segmentationResultId, blockIndex), gdPictureSegmenter.GetBlockBottom(segmentationResultId, blockIndex) - gdPictureSegmenter.GetBlockTop(segmentationResultId, blockIndex)))
                Dim paragraphsCount As Integer = gdPictureSegmenter.GetBlockParagraphCount(segmentationResultId, blockIndex)
                Dim paragraphIndex As Integer = gdPictureSegmenter.GetBlockFirstParagraphIndex(segmentationResultId, blockIndex)
                Do While paragraphIndex < (gdPictureSegmenter.GetBlockFirstParagraphIndex(segmentationResultId, blockIndex) + paragraphsCount)
                    paragraphs.Add(New Rectangle(gdPictureSegmenter.GetParagraphLeft(segmentationResultId, paragraphIndex), gdPictureSegmenter.GetParagraphTop(segmentationResultId, paragraphIndex), gdPictureSegmenter.GetParagraphRight(segmentationResultId, paragraphIndex) - gdPictureSegmenter.GetParagraphLeft(segmentationResultId, paragraphIndex), gdPictureSegmenter.GetParagraphBottom(segmentationResultId, paragraphIndex) - gdPictureSegmenter.GetParagraphTop(segmentationResultId, paragraphIndex)))
                    Dim textLinesCount As Integer = gdPictureSegmenter.GetParagraphTextLineCount(segmentationResultId, paragraphIndex)
                    Dim textLineIndex As Integer = gdPictureSegmenter.GetParagraphFirstTextLineIndex(segmentationResultId, paragraphIndex)
                    Do While textLineIndex < (gdPictureSegmenter.GetParagraphFirstTextLineIndex(segmentationResultId, paragraphIndex) + textLinesCount)
                        lines.Add(New Rectangle(gdPictureSegmenter.GetTextLineLeft(segmentationResultId, textLineIndex), gdPictureSegmenter.GetTextLineTop(segmentationResultId, textLineIndex), gdPictureSegmenter.GetTextLineRight(segmentationResultId, textLineIndex) - gdPictureSegmenter.GetTextLineLeft(segmentationResultId, textLineIndex), gdPictureSegmenter.GetTextLineBottom(segmentationResultId, textLineIndex) - gdPictureSegmenter.GetTextLineTop(segmentationResultId, textLineIndex)))
                        Dim wordsCount As Integer = gdPictureSegmenter.GetTextLineWordCount(segmentationResultId, textLineIndex)
                        Dim wordIndex As Integer = gdPictureSegmenter.GetTextLineFirstWordIndex(segmentationResultId, textLineIndex)
                        Do While wordIndex < (gdPictureSegmenter.GetTextLineFirstWordIndex(segmentationResultId, textLineIndex) + wordsCount)
                            words.Add(New Rectangle(gdPictureSegmenter.GetWordLeft(segmentationResultId, wordIndex), gdPictureSegmenter.GetWordTop(segmentationResultId, wordIndex), gdPictureSegmenter.GetWordRight(segmentationResultId, wordIndex) - gdPictureSegmenter.GetWordLeft(segmentationResultId, wordIndex), gdPictureSegmenter.GetWordBottom(segmentationResultId, wordIndex) - gdPictureSegmenter.GetWordTop(segmentationResultId, wordIndex)))
                            Dim charactersCount As Integer = gdPictureSegmenter.GetWordCharacterCount(segmentationResultId, wordIndex)
                            Dim characterIndex As Integer = gdPictureSegmenter.GetWordFirstCharacterIndex(segmentationResultId, wordIndex)
                            Do While characterIndex < (gdPictureSegmenter.GetWordFirstCharacterIndex(segmentationResultId, wordIndex) + charactersCount)
                                chars.Add(New Rectangle(gdPictureSegmenter.GetCharacterLeft(segmentationResultId, characterIndex), gdPictureSegmenter.GetCharacterTop(segmentationResultId, characterIndex), gdPictureSegmenter.GetCharacterRight(segmentationResultId, characterIndex) - gdPictureSegmenter.GetCharacterLeft(segmentationResultId, characterIndex), gdPictureSegmenter.GetCharacterBottom(segmentationResultId, characterIndex) - gdPictureSegmenter.GetCharacterTop(segmentationResultId, characterIndex)))
                                characterIndex = characterIndex + 1
                            Loop

                            wordIndex = wordIndex + 1
                        Loop

                        textLineIndex = textLineIndex + 1
                    Loop

                    paragraphIndex = paragraphIndex + 1
                Loop

            End If

            blockIndex = blockIndex + 1
        Loop

    End Sub

    Private Shared Function IsImageBlockType(ByVal blockType As OCRBlockType) As Boolean
        Return (blockType = OCRBlockType.FlowingImage) OrElse (blockType = OCRBlockType.HeadingImage) OrElse (blockType = OCRBlockType.PulloutImage)
    End Function

    Private Shared Function IsTextBlockType(ByVal blockType As OCRBlockType) As Boolean
        Return (blockType = OCRBlockType.CaptionText) OrElse (blockType = OCRBlockType.FlowingText) OrElse (blockType = OCRBlockType.HeadingText) OrElse (blockType = OCRBlockType.PulloutText) OrElse (blockType = OCRBlockType.Table)
    End Function

    Private Shared Function IsLineBlockType(ByVal blockType As OCRBlockType) As Boolean
        Return (blockType = OCRBlockType.VerticalLine) OrElse (blockType = OCRBlockType.HorizontalLine)
    End Function

    Private Shared Sub AddRegions(ByVal gdViewer As GdViewer, ByVal rectangles As IEnumerable(Of Rectangle),
                                  ByVal color As Color, ByVal horizontalResolution As Single, ByVal verticalResolution As Single)
        For Each rectangle In rectangles
            Dim regionId As Integer = gdViewer.AddRegionInches("", rectangle.Left / horizontalResolution, rectangle.Top / verticalResolution, (rectangle.Right - rectangle.Left) / horizontalResolution, (rectangle.Bottom - rectangle.Top) / verticalResolution, ForegroundMixMode.ForegroundMixModeUNDEFINED, color)
            gdViewer.SetRegionEditable(regionId, False)
            gdViewer.SetRegionBorderWidth(regionId, 1)
            gdViewer.SetRegionBorderColor(regionId, color)
        Next
    End Sub

End Class
