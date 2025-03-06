async function loadMarkdown(filePath, buttonElement) {
    let containerId = `markdown-content-${filePath.replace(/\//g, "-")}`;
    let markdownContainer = document.getElementById(containerId);

    // **如果已经加载，切换显示/隐藏**
    if (markdownContainer.innerHTML.trim() !== "") {
        markdownContainer.style.display = markdownContainer.style.display === "none" ? "block" : "none";
        return;
    }

    const mdURL = `https://raw.githubusercontent.com/zlxin0110/LearnLanguage/main/docs/Repository/${filePath}.md`;

    try {
        const response = await fetch(mdURL);
        if (!response.ok) throw new Error("Failed to fetch Markdown file.");

        const markdownText = await response.text();
        let htmlContent = marked.parse(markdownText);

        // **自动格式化 Markdown 表格**
        htmlContent = htmlContent.replace(/<table>/g, '<table border="1" style="border-collapse: collapse; width: 100%;">');

        markdownContainer.innerHTML = htmlContent;
        markdownContainer.style.display = "block"; // 显示内容
    } catch (error) {
        console.error("Error:", error);
        markdownContainer.innerHTML = "<p>加载 Markdown 失败。</p>";
        markdownContainer.style.display = "block";
    }
}
