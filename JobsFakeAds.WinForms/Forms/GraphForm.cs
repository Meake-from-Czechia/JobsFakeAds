using JobsFakeAds.WinForms.Data;

namespace JobsFakeAds.WinForms.Forms;

public partial class GraphForm : Form
{
    private readonly AppDbContext _appDbContext;
    private int _width;
    private int _height;
    private Pen _axisPen;
    private Brush _dataBrush;
    private float _axisPadding;
    private List<GraphData> _graphData;
    private int _maxCount;
    private int _dataCount;

    public GraphForm()
    {
        InitializeComponent();
        _width = pictureBox.Width;
        _height = pictureBox.Height;
        _appDbContext = new AppDbContext();
        _axisPen = new Pen(Color.Black, 1);
        _dataBrush = new SolidBrush(Color.Blue);
        _axisPadding = 0.1f;
        _graphData = new List<GraphData>();
        foreach (var company in _appDbContext.Companies.ToList().OrderBy(c => c.Name))
        {
            _graphData.Add(new(company.Name, _appDbContext.JobOffers.Where(j => j.Company == company).ToList().Count));
        }

        _maxCount = _graphData.MaxBy(x => x.OfferCount).OfferCount;
        _dataCount = _graphData.Count;
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
        DrawAxis(g);
    }

    private void DrawData(Graphics g)
    {
        int offset = 0;
        foreach (var data in _graphData)
        {
            g.FillRectangle(_dataBrush, 0.5f + (float)(_axisPadding * _width) + offset * ((_width - 0.5f) / _dataCount),
                (_axisPadding * _height),
                0.5f + (float)(_axisPadding * _width) + offset * ((_width - 0.5f) / _dataCount) + ((_width - 0.5f) / _dataCount), _height);
        }
    }

    private void DrawAxis(Graphics g)
    {
        // Axis x
        g.DrawLine(_axisPen, (float)(_axisPadding * _width), (float)(_axisPadding * _height),
            (float)((1f - _axisPadding) * _width), (float)(_axisPadding * _height));
        // Axis y
        g.DrawLine(_axisPen, (float)(_axisPadding * _width), (float)(_axisPadding * _height),
            (float)((_axisPadding) * _width), (float)((1 - _axisPadding) * _height));
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
    }
}