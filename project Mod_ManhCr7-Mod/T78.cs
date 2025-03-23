public interface T78
{
	bool isConnected();

	void setHandler(T63 messageHandler);

	void connect(string host, int port);

	void sendMessage(T97 message);

	void close();
}
