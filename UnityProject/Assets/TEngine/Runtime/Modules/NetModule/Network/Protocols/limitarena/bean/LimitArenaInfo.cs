using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 无间之战信息
 */
public class LimitArenaInfo : IMessageSerialize 
{
	//本轮胜利次数
	int _winTimes;	
	//今日最大胜利次数
	int _maxWinTimesToday;	
	//本轮失败次数
	int _lostTimes;	
	//领取奖励 到了几次胜利
	int _winRewardedPos;	
	//已重置次数
	int _refreshTimes;	
	//0:不清除 1：清除
	int _clearOpponent;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//本轮胜利次数
		SerializeUtils.WriteInt(stream, _winTimes);
		//今日最大胜利次数
		SerializeUtils.WriteInt(stream, _maxWinTimesToday);
		//本轮失败次数
		SerializeUtils.WriteInt(stream, _lostTimes);
		//领取奖励 到了几次胜利
		SerializeUtils.WriteInt(stream, _winRewardedPos);
		//已重置次数
		SerializeUtils.WriteInt(stream, _refreshTimes);
		//0:不清除 1：清除
		SerializeUtils.WriteInt(stream, _clearOpponent);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//本轮胜利次数
		_winTimes = SerializeUtils.ReadInt(stream);
		//今日最大胜利次数
		_maxWinTimesToday = SerializeUtils.ReadInt(stream);
		//本轮失败次数
		_lostTimes = SerializeUtils.ReadInt(stream);
		//领取奖励 到了几次胜利
		_winRewardedPos = SerializeUtils.ReadInt(stream);
		//已重置次数
		_refreshTimes = SerializeUtils.ReadInt(stream);
		//0:不清除 1：清除
		_clearOpponent = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 本轮胜利次数
	 */
	public int WinTimes
	{
		set { _winTimes = value; }
	    get { return _winTimes; }
	}
	
	/**
	 * 今日最大胜利次数
	 */
	public int MaxWinTimesToday
	{
		set { _maxWinTimesToday = value; }
	    get { return _maxWinTimesToday; }
	}
	
	/**
	 * 本轮失败次数
	 */
	public int LostTimes
	{
		set { _lostTimes = value; }
	    get { return _lostTimes; }
	}
	
	/**
	 * 领取奖励 到了几次胜利
	 */
	public int WinRewardedPos
	{
		set { _winRewardedPos = value; }
	    get { return _winRewardedPos; }
	}
	
	/**
	 * 已重置次数
	 */
	public int RefreshTimes
	{
		set { _refreshTimes = value; }
	    get { return _refreshTimes; }
	}
	
	/**
	 * 0:不清除 1：清除
	 */
	public int ClearOpponent
	{
		set { _clearOpponent = value; }
	    get { return _clearOpponent; }
	}
	
}