using System.Drawing.Drawing2D;
using JobsFakeAds.WinForms.Data;

namespace JobsFakeAds.WinForms.Forms;

public partial class GraphForm : Form
{
    private readonly AppDbContext _appDbContext;
    private int _width;
    private int _height;
    private Pen _axisPen;
    private float _axisPadding;
    private float _startX;
    private float _startY;
    private float _endX;
    private float _endY;
    private List<GraphData> _graphData;
    private int _maxCount;
    private int _dataCount;
    private int _dataPointPadding;
    private Random _random;

    public GraphForm()
    {
        InitializeComponent();
        _width = pictureBox.Width;
        _height = pictureBox.Height;
        _appDbContext = new AppDbContext();
        _axisPen = new Pen(Color.Black, 1);
        _axisPadding = 0.15f;
        _startX = (float)(_axisPadding * _width);
        _startY = (float)(_axisPadding * _height);
        _endX = (float)((1f - _axisPadding) * _width);
        _endY = (float)((1f - _axisPadding) * _height);
        _graphData = new List<GraphData>();
        _dataPointPadding = 3; // jaký podíl má padding k datovému sloupci (3 = jedna třetina je padding)
        foreach (var company in _appDbContext.Companies.ToList().OrderBy(c => c.Name))
        {
            _graphData.Add(new(company.Name, _appDbContext.JobOffers.Where(j => j.Company == company).ToList().Count));
        }

        _maxCount = _graphData.MaxBy(x => x.OfferCount).OfferCount;
        _dataCount = _graphData.Count;
        _random = new Random();
    }

    private void pictureBox_Paint(object sender, PaintEventArgs e)
    {
        _width = pictureBox.Width;
        _height = pictureBox.Height;
        var g = e.Graphics;
        g.TranslateTransform(0, pictureBox.Height);
        g.ScaleTransform(1, -1);
        DrawGraph(g);
    }

    private void DrawGraph(Graphics g)
    {
        DrawData(g);
        DrawAxis(g);
    }

    private void DrawData(Graphics g)
    {
        // Výška, ve které se bude zobrazovat graf
        float maxDataHeight = (float)((1 - _axisPadding) * _height - _axisPadding * _height);
        // Velikost jednoho "bodu" -> pokud máme např. maximální počet nabídek 3, rozdělí se dostupná výška na 3 části
        float dataPointHeight = maxDataHeight / _maxCount;

        // Šířka, ve které se bude zobrazovat graf
        float maxDataWidth = (float)((1 - _axisPadding) * _width - _axisPadding * _width);
        // Šířka jednoho sloupce i s paddingy
        float dataPointWidth = maxDataWidth / _dataCount;
        // Šířka paddingu jednoho sloupce
        float dataPadding = dataPointWidth / _dataPointPadding;
        // Šířka dat jednoho sloupce
        float dataWidth = dataPointWidth - dataPadding;
        GraphData data;
        for (int i = 0; i < _graphData.Count; i++)
        {
            data = _graphData[i];
            float graphX = (_startX + dataPadding + i * dataPointWidth);
            g.FillRectangle(new SolidBrush(Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256))),
                graphX, _startY, dataWidth, dataPointHeight * data.OfferCount);
            Matrix transform = g.Transform;
            g.ResetTransform();
            using (Font font = new Font("Arial", _height/50f, FontStyle.Bold))
            {
                string companyName = data.CompanyName;
                SizeF textSize = g.MeasureString(companyName, font);
                float centerX = graphX + (dataWidth / 2);
                float textY = pictureBox.Height - _startY + textSize.Width/2;
                g.TranslateTransform(centerX, textY);
                g.RotateTransform(-90); // -90 degrees rotates counterclockwise (to the left)
                g.DrawString(companyName, font, Brushes.Black, -textSize.Width / 2, 0);
            }
            g.Transform = transform;
        }
    }

    private void DrawAxis(Graphics g)
    {
        _startX = (float)(_axisPadding * _width);
        _startY = (float)(_axisPadding * _height);
        _endX = (float)((1f - _axisPadding) * _width);
        _endY = (float)((1f - _axisPadding) * _height);
        // Axis x
        g.DrawLine(_axisPen, _startX, _startY,
            _endX, _startY);
        // Axis y
        g.DrawLine(_axisPen, _startX, _startY,
            _startX, _endY);
    }

    private void pictureBox_Resize(object sender, EventArgs e)
    {
        pictureBox.Refresh();
    }
}

public class GraphData
{
    public string CompanyName { get; set; }
    public int OfferCount { get; set; }

    public GraphData(string companyName, int offerCount)
    {
        CompanyName = companyName;
        OfferCount = offerCount;
    }
}