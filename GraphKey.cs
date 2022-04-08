using System.Collections.Generic;

namespace graphicKey
{
    class GraphKey
    {
        public int col;
        public int row;
        public int VertexSize;
        public List<int> passedVertex = new List<int>();
        public GraphKey()
        {
            col = 3;
            row = 3;
            VertexSize = 50;
        }
    }
}
