import os

model = "sentence-transformers/msmarco-distilbert-base-v3"
top_k = 1

port = 45678
workspace_dir = os.path.join(os.path.abspath('workspace'))
datafile = "./data/apis.csv"

max_docs = 502
